using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_entity
{
    public partial class frmMusteriSE : Form
    {
        Müsteri _musteri;
        public frmMusteriSE(Müsteri musteri)
        {
            InitializeComponent();
            _musteri = musteri;
            gtpSiparis.MinDate = DateTime.Now;

        }
       
        private void FrmMusteriSE_Load(object sender, EventArgs e)
        {
            lblKullanici.Text = "Hoşgeldin "+_musteri.MusteriAd;

            //combobox şehirleri içeren kod
            var sehirler = Singleton.Context.SirketAdres.ToList();
            cmbIl.DisplayMember = "Il";
            cmbIl.ValueMember = "SirketAdresID";
            cmbIl.DataSource = sehirler;
            cmbIl.SelectedIndex = -1;

           
           //var sirketler = Singleton.Context.Sirket.Where(s => s.SirketAdresID == (int)cmbIl.SelectedItem).ToList();
           // MessageBox.Show(sirketler.ToString()); 
             


            List<Urun> uruns;
           // var sorgu=Singleton.Context.SirketUrun.Where
            uruns = Singleton.Context.Urun.ToList();
            

            foreach (var item in uruns)
            {
                string[] degerler = new string[3]
                {
                    
                    item.UrunAdi,
                    item.UrunUcreti==null?"":item.UrunUcreti.ToString(),
                    item.UrunBoyut==null?"":item.UrunBoyut.ToString(),
                    
                };
                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;
                lstUrun.Items.Add(viewItem);
            }
            
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            lstUrun.Items.Clear();
            List<Urun> uruns;
            if (string.IsNullOrWhiteSpace(txtAra.Text))
            {
                uruns = Singleton.Context.Urun.ToList();
            }
            else
            {
                string[] kelimeler = txtAra.Text.Trim().Split();
                uruns = Singleton.Context.Urun.Where(p => p.UrunAdi.Contains(txtAra.Text)).ToList();
            }
            

            foreach (var item in uruns)
            {
                string[] degerler = new string[3]
                {
                    
                    item.UrunAdi==null?"":item.UrunAdi,
                    item.UrunUcreti==null?"":item.UrunUcreti.ToString(),
                    item.UrunBoyut==null?"":item.UrunBoyut.ToString(),
                   
                };
                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;
                lstUrun.Items.Add(viewItem);
            }

        }

        //private void btnSiparisSec_Click(object sender, EventArgs e)
        //{
        //    //listviewden satır seçip textboxa aktarma kodu
        //    if (lstUrun.SelectedItems.Count > 0)
        //    {
        //        txtUrunAdi.Text = lstUrun.SelectedItems[0].SubItems[0].Text;
        //        txtUcret.Text = lstUrun.SelectedItems[0].SubItems[1].Text;
        //        txtUrunBoyut.Text = lstUrun.SelectedItems[0].SubItems[2].Text;
        //    }
        //}

        private void btnTutarHesapla_Click(object sender, EventArgs e)
        {
            if (nudAdet.Value==0)
            {
                MessageBox.Show("Lütfen Ürün Adeti Giriniz.");
            }
            //nudAdet.Maximum = lstUrun.SelectedIndices
            else
            {
                decimal urunTutar = nudAdet.Value * Convert.ToDecimal(lstUrun.SelectedItems[0].SubItems[1].Text);
                txtTutarHesapla.Text = urunTutar.ToString();
            }
        }

      

        private void BtnSiparisVer_Click_1(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis()
            {
                SiparisZamani=DateTime.Now,
                TeslimZamani=gtpSiparis.Value,
                SiparisTutar=Convert.ToDecimal(txtTutarHesapla.Text),
                MusteriID = _musteri.MusteriID

            };
            Singleton.Context.Siparis.Add(siparis);

            try
            {
                int ess = Singleton.Context.SaveChanges();
                if (ess > 0)
                {
                    MessageBox.Show("Işlem başarılı");

                }
                else
                {
                    MessageBox.Show("Herhangi işlem yapılmadı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata");
            }

        


    }

     
        private void BtnGeri_Click(object sender, EventArgs e)
        {
            frmMusteriIslemler frm = new frmMusteriIslemler(_musteri);
            frm.Show();
            this.Close();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("Programdan Çıkmak İstediğinizden Emin Misiniz?", "Çıkış Mesajı!", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                //Evet tıklandığında Yapılacak İşlemler
                Application.Exit(); // Evet tıklandığında uygulama kapanacak

            }
        }
    }
}
