using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme_entity
{
    public partial class frmKayit : Form
    {
        public frmKayit()
        {
            InitializeComponent();
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {

            Adres adres = new Adres()
            {
               
                Mahalle = txtMahalle.Text,
                Sokak = txtSokak.Text,
                ApartNo = Convert.ToInt32(txtApartmanNo.Text),
                DaireNo = Convert.ToInt32(txtDaireNo.Text),
                Il = txtIl.Text,
                Ilce = txtIlce.Text

            };
            Singleton.Context.Adres.Add(adres);

           
            Müsteri müsteri = new Müsteri()
            {
                MusteriAd = txtAd.Text,
                MusteriSoyad = txtSoyad.Text,
                Mail = txtMail.Text,
                Parola = txtParola.Text,
                AdresID = adres.AdresID
                
            };
           
            Singleton.Context.Müsteri.Add(müsteri);

           

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
            frmMüsteriGiris frm = new frmMüsteriGiris();
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
