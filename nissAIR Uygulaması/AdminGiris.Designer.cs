namespace nissAIR_Uygulaması
{
    partial class AdminGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminGiris));
            this.lblAdminPanelGiris = new System.Windows.Forms.Label();
            this.btnGirisYap = new MaterialSkin.Controls.MaterialButton();
            this.txtSifre = new MaterialSkin.Controls.MaterialTextBox();
            this.txtKullaniciAdi = new MaterialSkin.Controls.MaterialTextBox();
            this.pbUserProfile = new System.Windows.Forms.PictureBox();
            this.btnGeriDon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdminPanelGiris
            // 
            this.lblAdminPanelGiris.AutoSize = true;
            this.lblAdminPanelGiris.BackColor = System.Drawing.Color.Transparent;
            this.lblAdminPanelGiris.Font = new System.Drawing.Font("Bodoni Bd BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdminPanelGiris.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblAdminPanelGiris.Location = new System.Drawing.Point(470, 213);
            this.lblAdminPanelGiris.Name = "lblAdminPanelGiris";
            this.lblAdminPanelGiris.Size = new System.Drawing.Size(262, 35);
            this.lblAdminPanelGiris.TabIndex = 24;
            this.lblAdminPanelGiris.Text = "Admin Panel Girişi";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGirisYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGirisYap.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGirisYap.Depth = 0;
            this.btnGirisYap.HighEmphasis = true;
            this.btnGirisYap.Icon = null;
            this.btnGirisYap.Location = new System.Drawing.Point(643, 376);
            this.btnGirisYap.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGirisYap.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGirisYap.Size = new System.Drawing.Size(89, 36);
            this.btnGirisYap.TabIndex = 23;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGirisYap.UseAccentColor = false;
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.AnimateReadOnly = false;
            this.txtSifre.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtSifre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifre.Depth = 0;
            this.txtSifre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSifre.Hint = "Şifre";
            this.txtSifre.LeadingIcon = null;
            this.txtSifre.Location = new System.Drawing.Point(469, 317);
            this.txtSifre.MaxLength = 50;
            this.txtSifre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSifre.Multiline = false;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Password = true;
            this.txtSifre.Size = new System.Drawing.Size(263, 50);
            this.txtSifre.TabIndex = 22;
            this.txtSifre.Text = "";
            this.txtSifre.TrailingIcon = null;
            this.txtSifre.UseAccent = false;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.AnimateReadOnly = false;
            this.txtKullaniciAdi.BackColor = System.Drawing.SystemColors.Highlight;
            this.txtKullaniciAdi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKullaniciAdi.Depth = 0;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtKullaniciAdi.Hint = "Kullanıcı Adı";
            this.txtKullaniciAdi.LeadingIcon = null;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(469, 261);
            this.txtKullaniciAdi.MaxLength = 50;
            this.txtKullaniciAdi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtKullaniciAdi.Multiline = false;
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(263, 50);
            this.txtKullaniciAdi.TabIndex = 20;
            this.txtKullaniciAdi.Text = "";
            this.txtKullaniciAdi.TrailingIcon = null;
            this.txtKullaniciAdi.UseAccent = false;
            // 
            // pbUserProfile
            // 
            this.pbUserProfile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbUserProfile.BackgroundImage")));
            this.pbUserProfile.Location = new System.Drawing.Point(279, 231);
            this.pbUserProfile.Name = "pbUserProfile";
            this.pbUserProfile.Size = new System.Drawing.Size(167, 167);
            this.pbUserProfile.TabIndex = 21;
            this.pbUserProfile.TabStop = false;
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.geri;
            this.btnGeriDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeriDon.FlatAppearance.BorderSize = 0;
            this.btnGeriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeriDon.Location = new System.Drawing.Point(6, 11);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(37, 25);
            this.btnGeriDon.TabIndex = 30;
            this.btnGeriDon.UseVisualStyleBackColor = true;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // AdminGiris
            // 
            this.AcceptButton = this.btnGirisYap;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.klasikArkaplan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 585);
            this.Controls.Add(this.btnGeriDon);
            this.Controls.Add(this.lblAdminPanelGiris);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.pbUserProfile);
            this.Controls.Add(this.txtKullaniciAdi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AdminGiris";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminGiris";
            this.Load += new System.EventHandler(this.AdminGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdminPanelGiris;
        private MaterialSkin.Controls.MaterialButton btnGirisYap;
        private MaterialSkin.Controls.MaterialTextBox txtSifre;
        private System.Windows.Forms.PictureBox pbUserProfile;
        private MaterialSkin.Controls.MaterialTextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnGeriDon;
    }
}