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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private void BayiGirisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBayiGiris frm = new frmBayiGiris();
            frm.Show();
            this.Hide();
        }

        private void MüsteriGirisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMüsteriGiris frm = new frmMüsteriGiris();
            frm.Show();
            this.Hide();
        }

        private void AdminGirisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminGiris frm = new frmAdminGiris();
            frm.Show();
            this.Hide();

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
