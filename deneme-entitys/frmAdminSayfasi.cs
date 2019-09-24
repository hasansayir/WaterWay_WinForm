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
    public partial class frmAdminSayfasi : Form
    {
        public frmAdminSayfasi()
        {
            InitializeComponent();
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
           SirketAdres adres = new SirketAdres()
            {
               
                Mahalle = txtMahalle.Text,
                Sokak = txtSokak.Text,
                Il = txtIl.Text,
                Ilce = txtIlce.Text,
                
           };
            Singleton.Context.SirketAdres.Add(adres);

            Sirket sirket = new Sirket()
            {
                SirketAdi = txtSirketAdi.Text,
                Mail = txtMail.Text,
                Parola = txtParola.Text,
                SirketAdresID = adres.SirketAdresID
            };

            Singleton.Context.Sirket.Add(sirket);

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
            frmAdminGiris frm = new frmAdminGiris();
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
