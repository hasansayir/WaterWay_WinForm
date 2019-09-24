namespace deneme_entity
{
    partial class frmMusteriSiparisDurum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriSiparisDurum));
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.lstSiparis = new System.Windows.Forms.ListView();
            this.SiparisID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SiparisZamani = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TeslimZamani = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SiparisTutar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SirketID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Location = new System.Drawing.Point(1097, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(56, 53);
            this.btnKapat.TabIndex = 18;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.SystemColors.Control;
            this.btnGeri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGeri.BackgroundImage")));
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Location = new System.Drawing.Point(12, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(124, 53);
            this.btnGeri.TabIndex = 17;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // lstSiparis
            // 
            this.lstSiparis.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SiparisID,
            this.SiparisZamani,
            this.TeslimZamani,
            this.SiparisTutar,
            this.SirketID,
            this.Adres});
            this.lstSiparis.FullRowSelect = true;
            this.lstSiparis.GridLines = true;
            this.lstSiparis.HideSelection = false;
            this.lstSiparis.Location = new System.Drawing.Point(12, 81);
            this.lstSiparis.Margin = new System.Windows.Forms.Padding(4);
            this.lstSiparis.Name = "lstSiparis";
            this.lstSiparis.Size = new System.Drawing.Size(1139, 370);
            this.lstSiparis.TabIndex = 19;
            this.lstSiparis.UseCompatibleStateImageBehavior = false;
            this.lstSiparis.View = System.Windows.Forms.View.Details;
            // 
            // SiparisID
            // 
            this.SiparisID.Text = "ID";
            this.SiparisID.Width = 48;
            // 
            // SiparisZamani
            // 
            this.SiparisZamani.Text = "Sipariş Zamanı";
            this.SiparisZamani.Width = 154;
            // 
            // TeslimZamani
            // 
            this.TeslimZamani.Text = "İstenilen Zaman";
            this.TeslimZamani.Width = 146;
            // 
            // SiparisTutar
            // 
            this.SiparisTutar.Text = "Tutar";
            this.SiparisTutar.Width = 58;
            // 
            // SirketID
            // 
            this.SirketID.Text = "Sirket";
            this.SirketID.Width = 100;
            // 
            // Adres
            // 
            this.Adres.Text = "Adres";
            this.Adres.Width = 468;
            // 
            // frmMusteriSiparisDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 645);
            this.ControlBox = false;
            this.Controls.Add(this.lstSiparis);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnGeri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMusteriSiparisDurum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMusteriSiparisDurum";
            this.Load += new System.EventHandler(this.FrmMusteriSiparisDurum_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ListView lstSiparis;
        private System.Windows.Forms.ColumnHeader SiparisID;
        private System.Windows.Forms.ColumnHeader SiparisZamani;
        private System.Windows.Forms.ColumnHeader TeslimZamani;
        private System.Windows.Forms.ColumnHeader SiparisTutar;
        private System.Windows.Forms.ColumnHeader SirketID;
        private System.Windows.Forms.ColumnHeader Adres;
    }
}