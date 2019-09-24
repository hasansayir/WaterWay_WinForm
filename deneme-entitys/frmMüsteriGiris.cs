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
    
    public partial class frmMüsteriGiris : Form
    {
        public static string _kullaniciAdi;
        public frmMüsteriGiris()
        {
            InitializeComponent();
            _kullaniciAdi = "";
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            frmKayit frm = new frmKayit();
            frm.Show();
            this.Close();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            var müsteri = Singleton.Context.Müsteri.Where(m => m.MusteriAd == txtKullaniciAdi.Text && m.Parola == txtParola.Text).FirstOrDefault();
            
            try
            {
                if (müsteri == null)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                    return;
                }
                else
                {
                    //_kullaniciAdi = müsteri.MusteriAd;

                    ////müsteri.Roller.where(r=> r.Ad=="Admin").FirstOrDefault();
                    //MessageBox.Show(müsteri.MusteriID.ToString());
                    frmMusteriIslemler frm = new frmMusteriIslemler(müsteri);
                    frm.Show();
                    this.Close();

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show("HATA");
            }
        }

      
        private void BtnGeri_Click(object sender, EventArgs e)
        {
            frmGiris frm = new frmGiris();
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
