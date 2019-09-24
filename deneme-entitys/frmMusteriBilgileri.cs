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
    public partial class frmMusteriBilgileri : Form
    {
        Müsteri _musteri;
        public frmMusteriBilgileri(Müsteri müsteri)
        {
            InitializeComponent();
            _musteri = müsteri;
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
