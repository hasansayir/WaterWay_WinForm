namespace deneme_entity
{
    partial class frmMusteriSE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriSE));
            this.grbSiparisEkrani = new System.Windows.Forms.GroupBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.lstUrun = new System.Windows.Forms.ListView();
            this.UrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunUcreti = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunBoyut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpSiparisEkrani = new System.Windows.Forms.GroupBox();
            this.gtpSiparis = new System.Windows.Forms.DateTimePicker();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            this.txtTutarHesapla = new System.Windows.Forms.TextBox();
            this.btnTutarHesapla = new System.Windows.Forms.Button();
            this.lblUrunAdet = new System.Windows.Forms.Label();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.cmbIl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBayi = new System.Windows.Forms.ComboBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.grbSiparisEkrani.SuspendLayout();
            this.grpSiparisEkrani.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // grbSiparisEkrani
            // 
            this.grbSiparisEkrani.Controls.Add(this.txtAra);
            this.grbSiparisEkrani.Controls.Add(this.btnAra);
            this.grbSiparisEkrani.Location = new System.Drawing.Point(15, 304);
            this.grbSiparisEkrani.Margin = new System.Windows.Forms.Padding(4);
            this.grbSiparisEkrani.Name = "grbSiparisEkrani";
            this.grbSiparisEkrani.Padding = new System.Windows.Forms.Padding(4);
            this.grbSiparisEkrani.Size = new System.Drawing.Size(496, 62);
            this.grbSiparisEkrani.TabIndex = 5;
            this.grbSiparisEkrani.TabStop = false;
            this.grbSiparisEkrani.Text = "Ürün Ara";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(176, 23);
            this.txtAra.Margin = new System.Windows.Forms.Padding(4);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(304, 22);
            this.txtAra.TabIndex = 5;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(21, 23);
            this.btnAra.Margin = new System.Windows.Forms.Padding(4);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 28);
            this.btnAra.TabIndex = 4;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // lstUrun
            // 
            this.lstUrun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UrunAdi,
            this.UrunUcreti,
            this.UrunBoyut});
            this.lstUrun.FullRowSelect = true;
            this.lstUrun.HideSelection = false;
            this.lstUrun.Location = new System.Drawing.Point(514, 78);
            this.lstUrun.Margin = new System.Windows.Forms.Padding(4);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(649, 288);
            this.lstUrun.TabIndex = 6;
            this.lstUrun.UseCompatibleStateImageBehavior = false;
            this.lstUrun.View = System.Windows.Forms.View.Details;
            // 
            // UrunAdi
            // 
            this.UrunAdi.Text = "Ürün Adı";
            this.UrunAdi.Width = 123;
            // 
            // UrunUcreti
            // 
            this.UrunUcreti.Text = "Ücret";
            this.UrunUcreti.Width = 118;
            // 
            // UrunBoyut
            // 
            this.UrunBoyut.Text = "Boyut";
            // 
            // grpSiparisEkrani
            // 
            this.grpSiparisEkrani.Controls.Add(this.gtpSiparis);
            this.grpSiparisEkrani.Controls.Add(this.nudAdet);
            this.grpSiparisEkrani.Controls.Add(this.txtTutarHesapla);
            this.grpSiparisEkrani.Controls.Add(this.btnTutarHesapla);
            this.grpSiparisEkrani.Controls.Add(this.lblUrunAdet);
            this.grpSiparisEkrani.Controls.Add(this.btnSiparisVer);
            this.grpSiparisEkrani.Location = new System.Drawing.Point(15, 384);
            this.grpSiparisEkrani.Margin = new System.Windows.Forms.Padding(4);
            this.grpSiparisEkrani.Name = "grpSiparisEkrani";
            this.grpSiparisEkrani.Padding = new System.Windows.Forms.Padding(4);
            this.grpSiparisEkrani.Size = new System.Drawing.Size(1155, 234);
            this.grpSiparisEkrani.TabIndex = 6;
            this.grpSiparisEkrani.TabStop = false;
            this.grpSiparisEkrani.Text = "Sipariş Ekranı";
            // 
            // gtpSiparis
            // 
            this.gtpSiparis.Location = new System.Drawing.Point(452, 50);
            this.gtpSiparis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gtpSiparis.Name = "gtpSiparis";
            this.gtpSiparis.Size = new System.Drawing.Size(200, 22);
            this.gtpSiparis.TabIndex = 14;
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(119, 46);
            this.nudAdet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(100, 22);
            this.nudAdet.TabIndex = 13;
            // 
            // txtTutarHesapla
            // 
            this.txtTutarHesapla.Location = new System.Drawing.Point(974, 69);
            this.txtTutarHesapla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTutarHesapla.Multiline = true;
            this.txtTutarHesapla.Name = "txtTutarHesapla";
            this.txtTutarHesapla.Size = new System.Drawing.Size(161, 34);
            this.txtTutarHesapla.TabIndex = 11;
            // 
            // btnTutarHesapla
            // 
            this.btnTutarHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTutarHesapla.Location = new System.Drawing.Point(974, 21);
            this.btnTutarHesapla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTutarHesapla.Name = "btnTutarHesapla";
            this.btnTutarHesapla.Size = new System.Drawing.Size(163, 33);
            this.btnTutarHesapla.TabIndex = 10;
            this.btnTutarHesapla.Text = "Tutar Hesapla";
            this.btnTutarHesapla.UseVisualStyleBackColor = true;
            this.btnTutarHesapla.Click += new System.EventHandler(this.btnTutarHesapla_Click);
            // 
            // lblUrunAdet
            // 
            this.lblUrunAdet.AutoSize = true;
            this.lblUrunAdet.Location = new System.Drawing.Point(12, 50);
            this.lblUrunAdet.Name = "lblUrunAdet";
            this.lblUrunAdet.Size = new System.Drawing.Size(72, 17);
            this.lblUrunAdet.TabIndex = 8;
            this.lblUrunAdet.Text = "Ürün Adet";
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisVer.Location = new System.Drawing.Point(985, 195);
            this.btnSiparisVer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(163, 33);
            this.btnSiparisVer.TabIndex = 7;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisVer.Click += new System.EventHandler(this.BtnSiparisVer_Click_1);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(24, 93);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(0, 31);
            this.lblKullanici.TabIndex = 7;
            // 
            // cmbIl
            // 
            this.cmbIl.FormattingEnabled = true;
            this.cmbIl.Location = new System.Drawing.Point(342, 103);
            this.cmbIl.Name = "cmbIl";
            this.cmbIl.Size = new System.Drawing.Size(121, 24);
            this.cmbIl.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Şehir Seç";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bayi Seç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(365, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 31);
            this.label3.TabIndex = 7;
            // 
            // cmbBayi
            // 
            this.cmbBayi.FormattingEnabled = true;
            this.cmbBayi.Location = new System.Drawing.Point(342, 163);
            this.cmbBayi.Name = "cmbBayi";
            this.cmbBayi.Size = new System.Drawing.Size(121, 24);
            this.cmbBayi.TabIndex = 8;
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Location = new System.Drawing.Point(1107, 1);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(56, 53);
            this.btnKapat.TabIndex = 13;
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
            this.btnGeri.TabIndex = 12;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.BtnGeri_Click);
            // 
            // frmMusteriSE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 645);
            this.ControlBox = false;
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.cmbBayi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbIl);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.grpSiparisEkrani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstUrun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbSiparisEkrani);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMusteriSE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MüsteriSiparisEkrani";
            this.Load += new System.EventHandler(this.FrmMusteriSE_Load);
            this.grbSiparisEkrani.ResumeLayout(false);
            this.grbSiparisEkrani.PerformLayout();
            this.grpSiparisEkrani.ResumeLayout(false);
            this.grpSiparisEkrani.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbSiparisEkrani;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListView lstUrun;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader UrunUcreti;
        private System.Windows.Forms.ColumnHeader UrunBoyut;
        private System.Windows.Forms.GroupBox grpSiparisEkrani;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.Label lblUrunAdet;
        private System.Windows.Forms.TextBox txtTutarHesapla;
        private System.Windows.Forms.Button btnTutarHesapla;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.DateTimePicker gtpSiparis;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.ComboBox cmbIl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBayi;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnGeri;
    }
}