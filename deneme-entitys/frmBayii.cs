using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_entity
{
   
    public partial class frmBayii : Form
    {
        Sirket _sirket;
        public frmBayii(Sirket sirket)
        {
            InitializeComponent();
            _sirket = sirket;
        }



     
        //private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
        //    {
        //        dataGridView1.CurrentRow.Selected = true;

        //        txtUrunAdi.Text = dataGridView1.Rows[e.RowIndex].Cells["UrunAdi"].FormattedValue.ToString();
        //        txtUrunUcreti.Text = dataGridView1.Rows[e.RowIndex].Cells["UrunUcreti"].FormattedValue.ToString();
        //        txtUrunBoyut.Text = dataGridView1.Rows[e.RowIndex].Cells["UrunBoyut"].FormattedValue.ToString();
        //        txtUrunStok.Text = dataGridView1.Rows[e.RowIndex].Cells["UrunStok"].FormattedValue.ToString();

        //    }
        //}

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUrunAdi.Text) || string.IsNullOrWhiteSpace(txtUrunBoyut.Text) || string.IsNullOrWhiteSpace(txtUrunStok.Text) || string.IsNullOrWhiteSpace(txtUrunUcreti.Text))
            {
                MessageBox.Show("Boş Girilemez");
                return;
            }
            Urun urun = new Urun()
            {

                UrunAdi = txtUrunAdi.Text,
                UrunUcreti = Convert.ToDecimal(txtUrunUcreti.Text),
                UrunBoyut = Convert.ToDouble(txtUrunBoyut.Text),
                UrunStok = Convert.ToInt32(txtUrunStok.Text),


            };
            
            Singleton.Context.Urun.Add(urun);
            //urunıd olustu

            SirketUrun sirketUrun = new SirketUrun()
            {
                SirketID=_sirket.SirketID,
                UrunID=urun.UrunID
            };
            Singleton.Context.SirketUrun.Add(sirketUrun);
            //sirketurunID olustu

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

        private void BtnListele_Click(object sender, EventArgs e)
        {
            lstUrun.Items.Clear();

           
            var SirketinUrunleri = (from su in Singleton.Context.SirketUrun
                        join u in Singleton.Context.Urun on su.UrunID equals u.UrunID
                        where su.SirketID==_sirket.SirketID
                        select new
                        {
                            u.UrunID,
                            u.UrunAdi,
                            u.UrunUcreti,
                            u.UrunBoyut,
                            u.UrunStok
                        }).ToList();

            foreach (var item in SirketinUrunleri)
            {
                string[] degerler = new string[5]
                {
                    
                    item.UrunID.ToString(),
                    item.UrunAdi,
                    item.UrunUcreti.ToString(),
                    item.UrunBoyut.ToString(),
                    item.UrunStok.ToString()
                };
                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;
                lstUrun.Items.Add(viewItem);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (lstUrun.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Silme işlemi öncesinde bir ürün seçmeniz gerekmektedir.");
                return;
            }
            var item = lstUrun.SelectedItems[0];
            SirketUrun urun = (SirketUrun)item.Tag;
            Singleton.Context.SirketUrun.Remove(urun);


            //todo sil metodu çalıştırılacak



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

        private void SiparişleriGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBayiSiparis frm = new FormBayiSiparis(_sirket);
            frm.Show();
        }

        private void FrmBayii_Load(object sender, EventArgs e)
        {
            lblSirketAdi.Text = _sirket.SirketAdi;
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            frmBayiGiris frm = new frmBayiGiris();
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
