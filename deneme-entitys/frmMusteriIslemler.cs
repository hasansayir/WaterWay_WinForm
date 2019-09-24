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
    public partial class frmMusteriIslemler : Form
    {
        Müsteri _musteri;
        public frmMusteriIslemler(Müsteri müsteri)
        {
            InitializeComponent();
            _musteri = müsteri;
        }
        
        private void BtnSiparis_Click(object sender, EventArgs e)
        {
            frmMusteriSE frmSiparis = new frmMusteriSE(_musteri);
            frmSiparis.Show();
            this.Close();

        }

        private void BtnSiparisdDurum_Click(object sender, EventArgs e)
        {
            frmMusteriSiparisDurum frmMusteriSiparisDurum = new frmMusteriSiparisDurum(_musteri);
            frmMusteriSiparisDurum.Show();
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            frmMusteriBilgileri frmMusteriBilgileri = new frmMusteriBilgileri(_musteri);
            frmMusteriBilgileri.Show();
            this.Close();
        }

        private void FrmMusteriIslemler_Load(object sender, EventArgs e)
        {
            lblMusteri.Text = "Hosgeldin " + _musteri.MusteriAd;
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
