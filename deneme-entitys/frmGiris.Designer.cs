namespace deneme_entity
{
    partial class frmGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiris));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bayiGirisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müsteriGirisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminGirisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnKapat = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bayiGirisToolStripMenuItem,
            this.müsteriGirisToolStripMenuItem,
            this.adminGirisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1165, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bayiGirisToolStripMenuItem
            // 
            this.bayiGirisToolStripMenuItem.Name = "bayiGirisToolStripMenuItem";
            this.bayiGirisToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.bayiGirisToolStripMenuItem.Text = "Bayi Giris";
            this.bayiGirisToolStripMenuItem.Click += new System.EventHandler(this.BayiGirisToolStripMenuItem_Click);
            // 
            // müsteriGirisToolStripMenuItem
            // 
            this.müsteriGirisToolStripMenuItem.Name = "müsteriGirisToolStripMenuItem";
            this.müsteriGirisToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.müsteriGirisToolStripMenuItem.Text = "Müsteri Giris";
            this.müsteriGirisToolStripMenuItem.Click += new System.EventHandler(this.MüsteriGirisToolStripMenuItem_Click);
            // 
            // adminGirisToolStripMenuItem
            // 
            this.adminGirisToolStripMenuItem.Name = "adminGirisToolStripMenuItem";
            this.adminGirisToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.adminGirisToolStripMenuItem.Text = "Admin Giris";
            this.adminGirisToolStripMenuItem.Click += new System.EventHandler(this.AdminGirisToolStripMenuItem_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Location = new System.Drawing.Point(1097, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(56, 53);
            this.btnKapat.TabIndex = 18;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.BtnKapat_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 645);
            this.ControlBox = false;
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGiris";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bayiGirisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müsteriGirisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminGirisToolStripMenuItem;
        private System.Windows.Forms.Button btnKapat;
    }
}