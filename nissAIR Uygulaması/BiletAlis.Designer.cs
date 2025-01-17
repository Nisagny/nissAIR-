namespace nissAIR_Uygulaması
{
    partial class BiletAlis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiletAlis));
            this.gbYolcuBilgileri = new System.Windows.Forms.GroupBox();
            this.lblUyruk = new System.Windows.Forms.Label();
            this.txtTCNO = new System.Windows.Forms.TextBox();
            this.chbOnay = new System.Windows.Forms.CheckBox();
            this.txtKullaniciSoyadi = new System.Windows.Forms.TextBox();
            this.txtDogumGunu = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.cmbUyruk = new System.Windows.Forms.ComboBox();
            this.btnDevam = new MaterialSkin.Controls.MaterialButton();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.gbYolcuBilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbYolcuBilgileri
            // 
            this.gbYolcuBilgileri.BackColor = System.Drawing.Color.Transparent;
            this.gbYolcuBilgileri.Controls.Add(this.lblUyruk);
            this.gbYolcuBilgileri.Controls.Add(this.txtTCNO);
            this.gbYolcuBilgileri.Controls.Add(this.chbOnay);
            this.gbYolcuBilgileri.Controls.Add(this.txtKullaniciSoyadi);
            this.gbYolcuBilgileri.Controls.Add(this.txtDogumGunu);
            this.gbYolcuBilgileri.Controls.Add(this.txtEmail);
            this.gbYolcuBilgileri.Controls.Add(this.txtTelNo);
            this.gbYolcuBilgileri.Controls.Add(this.txtKullaniciAdi);
            this.gbYolcuBilgileri.Controls.Add(this.cmbUyruk);
            this.gbYolcuBilgileri.Location = new System.Drawing.Point(244, 125);
            this.gbYolcuBilgileri.Name = "gbYolcuBilgileri";
            this.gbYolcuBilgileri.Size = new System.Drawing.Size(561, 359);
            this.gbYolcuBilgileri.TabIndex = 40;
            this.gbYolcuBilgileri.TabStop = false;
            this.gbYolcuBilgileri.Text = "Yolcu Bilgileri";
            // 
            // lblUyruk
            // 
            this.lblUyruk.AutoSize = true;
            this.lblUyruk.Location = new System.Drawing.Point(353, 53);
            this.lblUyruk.Name = "lblUyruk";
            this.lblUyruk.Size = new System.Drawing.Size(203, 16);
            this.lblUyruk.TabIndex = 44;
            this.lblUyruk.Text = "Türkiye uyruklu iseniz TC giriniz. *";
            // 
            // txtTCNO
            // 
            this.txtTCNO.Location = new System.Drawing.Point(372, 72);
            this.txtTCNO.Name = "txtTCNO";
            this.txtTCNO.Size = new System.Drawing.Size(160, 22);
            this.txtTCNO.TabIndex = 43;
            // 
            // chbOnay
            // 
            this.chbOnay.AutoSize = true;
            this.chbOnay.Location = new System.Drawing.Point(162, 288);
            this.chbOnay.Name = "chbOnay";
            this.chbOnay.Size = new System.Drawing.Size(252, 20);
            this.chbOnay.TabIndex = 41;
            this.chbOnay.Text = "Bilgilerimin Doğruluğunu onaylıyorum.";
            this.chbOnay.UseVisualStyleBackColor = true;
            // 
            // txtKullaniciSoyadi
            // 
            this.txtKullaniciSoyadi.Location = new System.Drawing.Point(52, 123);
            this.txtKullaniciSoyadi.Name = "txtKullaniciSoyadi";
            this.txtKullaniciSoyadi.Size = new System.Drawing.Size(121, 22);
            this.txtKullaniciSoyadi.TabIndex = 7;
            this.txtKullaniciSoyadi.Text = "Soyadı";
            // 
            // txtDogumGunu
            // 
            this.txtDogumGunu.Location = new System.Drawing.Point(395, 177);
            this.txtDogumGunu.Name = "txtDogumGunu";
            this.txtDogumGunu.Size = new System.Drawing.Size(123, 22);
            this.txtDogumGunu.TabIndex = 5;
            this.txtDogumGunu.Text = "Doğum Günü";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 177);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 22);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Text = "Kullanıcı E-Mail";
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(52, 177);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(123, 22);
            this.txtTelNo.TabIndex = 3;
            this.txtTelNo.Text = "Kullanıcı Tel No";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(52, 72);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(121, 22);
            this.txtKullaniciAdi.TabIndex = 2;
            this.txtKullaniciAdi.Text = "Adı";
            // 
            // cmbUyruk
            // 
            this.cmbUyruk.FormattingEnabled = true;
            this.cmbUyruk.Items.AddRange(new object[] {
            "Türkiye",
            "Diğer Ülkeler"});
            this.cmbUyruk.Location = new System.Drawing.Point(189, 70);
            this.cmbUyruk.Name = "cmbUyruk";
            this.cmbUyruk.Size = new System.Drawing.Size(166, 24);
            this.cmbUyruk.TabIndex = 1;
            this.cmbUyruk.Text = "Uyruk Seçiniz";
            // 
            // btnDevam
            // 
            this.btnDevam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDevam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDevam.Depth = 0;
            this.btnDevam.HighEmphasis = true;
            this.btnDevam.Icon = null;
            this.btnDevam.Location = new System.Drawing.Point(961, 529);
            this.btnDevam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDevam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDevam.Size = new System.Drawing.Size(71, 36);
            this.btnDevam.TabIndex = 42;
            this.btnDevam.Text = "Devam";
            this.btnDevam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDevam.UseAccentColor = false;
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.BackColor = System.Drawing.Color.Transparent;
            this.lblFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFiyat.Location = new System.Drawing.Point(940, 500);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(0, 20);
            this.lblFiyat.TabIndex = 43;
            // 
            // BiletAlis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 588);
            this.Controls.Add(this.gbYolcuBilgileri);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.lblFiyat);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BiletAlis";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiletAlis";
            this.Load += new System.EventHandler(this.BiletAlis_Load);
            this.gbYolcuBilgileri.ResumeLayout(false);
            this.gbYolcuBilgileri.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbYolcuBilgileri;
        private System.Windows.Forms.TextBox txtDogumGunu;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.ComboBox cmbUyruk;
        private System.Windows.Forms.CheckBox chbOnay;
        private MaterialSkin.Controls.MaterialButton btnDevam;
        private System.Windows.Forms.TextBox txtKullaniciSoyadi;
        private System.Windows.Forms.Label lblUyruk;
        private System.Windows.Forms.TextBox txtTCNO;
        private System.Windows.Forms.Label lblFiyat;
    }
}