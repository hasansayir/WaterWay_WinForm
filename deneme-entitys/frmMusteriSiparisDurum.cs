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
    public partial class frmMusteriSiparisDurum : Form
    {
        Müsteri _musteri;
        public frmMusteriSiparisDurum(Müsteri müsteri)
        {
            InitializeComponent();
            _musteri = müsteri;
        }

      

        private void FrmMusteriSiparisDurum_Load(object sender, EventArgs e)
        {
            var siparis = Singleton.Context.SiparisUrun
                .Join(Singleton.Context.Urun, s => s.UrunID, u => u.UrunID, (s, u) =>
                       new {
                           s,u })
                .Join(Singleton.Context.SirketUrun,  su=> su.s.UrunID, sirketu => sirketu.UrunID, (su, sirketu) =>
                       new {
                           su,sirketu
                       })
                .Join(Singleton.Context.Sirket,sirketu=>sirketu.su.s.UrunID,sirket=>sirket.SirketID,(sirketu,sirket)=>
                       new {
                           sirket.SirketID,
                           sirket.SirketAdi,
                           sirket.SirketAdresID
                       })
                .ToList();



            foreach (var item in siparis)
            {
                string[] degerler = new string[2]
                {
                 
                    item.SirketAdi.ToString(),
                    item.SirketAdresID.ToString()
                };
                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;
                lstSiparis.Items.Add(viewItem);
            }
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

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            frmMusteriIslemler frm = new frmMusteriIslemler(_musteri);
            frm.Show();
            this.Close();
        }
    }
}
