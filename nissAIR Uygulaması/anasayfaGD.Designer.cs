namespace nissAIR_Uygulaması
{
    partial class anasayfaGD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUcusAra = new MaterialSkin.Controls.MaterialButton();
            this.dtpGidis = new System.Windows.Forms.DateTimePicker();
            this.cmbYolcular = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbNereye = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbNereden = new MaterialSkin.Controls.MaterialComboBox();
            this.btnGidisDonus = new MaterialSkin.Controls.MaterialButton();
            this.btnTekYön = new MaterialSkin.Controls.MaterialButton();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblMrb = new System.Windows.Forms.Label();
            this.dtpDonus = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblGidis = new System.Windows.Forms.Label();
            this.lblDonus = new System.Windows.Forms.Label();
            this.pbKullaniciFoto = new System.Windows.Forms.PictureBox();
            this.btnKullaniciProfili = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCheckIn = new MaterialSkin.Controls.MaterialButton();
            this.btnRehber = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbKullaniciFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUcusAra
            // 
            this.btnUcusAra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUcusAra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUcusAra.Depth = 0;
            this.btnUcusAra.HighEmphasis = true;
            this.btnUcusAra.Icon = null;
            this.btnUcusAra.Location = new System.Drawing.Point(918, 495);
            this.btnUcusAra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUcusAra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUcusAra.Name = "btnUcusAra";
            this.btnUcusAra.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUcusAra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUcusAra.Size = new System.Drawing.Size(91, 36);
            this.btnUcusAra.TabIndex = 17;
            this.btnUcusAra.Text = "Uçuş Ara";
            this.btnUcusAra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUcusAra.UseAccentColor = false;
            this.btnUcusAra.UseVisualStyleBackColor = true;
            this.btnUcusAra.Click += new System.EventHandler(this.btnUcusAra_Click);
            // 
            // dtpGidis
            // 
            this.dtpGidis.CalendarFont = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGidis.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpGidis.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtpGidis.CalendarTitleBackColor = System.Drawing.Color.Aqua;
            this.dtpGidis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpGidis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGidis.Location = new System.Drawing.Point(394, 370);
            this.dtpGidis.Name = "dtpGidis";
            this.dtpGidis.Size = new System.Drawing.Size(245, 27);
            this.dtpGidis.TabIndex = 16;
            // 
            // cmbYolcular
            // 
            this.cmbYolcular.AutoResize = false;
            this.cmbYolcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbYolcular.Depth = 0;
            this.cmbYolcular.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbYolcular.DropDownHeight = 174;
            this.cmbYolcular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYolcular.DropDownWidth = 121;
            this.cmbYolcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbYolcular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbYolcular.FormattingEnabled = true;
            this.cmbYolcular.Hint = "Yolcular";
            this.cmbYolcular.IntegralHeight = false;
            this.cmbYolcular.ItemHeight = 43;
            this.cmbYolcular.Items.AddRange(new object[] {
            "Yetişkin (+12 yaş)",
            "Çocuk (2-12 yaş)",
            "Bebek (0-2 yaş)",
            "Engelli",
            "Gazi/Şehit Yakını"});
            this.cmbYolcular.Location = new System.Drawing.Point(683, 348);
            this.cmbYolcular.MaxDropDownItems = 4;
            this.cmbYolcular.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbYolcular.Name = "cmbYolcular";
            this.cmbYolcular.Size = new System.Drawing.Size(180, 49);
            this.cmbYolcular.StartIndex = 0;
            this.cmbYolcular.TabIndex = 15;
            // 
            // cmbNereye
            // 
            this.cmbNereye.AutoResize = false;
            this.cmbNereye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbNereye.Depth = 0;
            this.cmbNereye.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbNereye.DropDownHeight = 174;
            this.cmbNereye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereye.DropDownWidth = 121;
            this.cmbNereye.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbNereye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbNereye.FormattingEnabled = true;
            this.cmbNereye.Hint = "Nereye";
            this.cmbNereye.IntegralHeight = false;
            this.cmbNereye.ItemHeight = 43;
            this.cmbNereye.Items.AddRange(new object[] {
            "Ankara",
            "İstanbul",
            "İzmir",
            "Van"});
            this.cmbNereye.Location = new System.Drawing.Point(157, 442);
            this.cmbNereye.MaxDropDownItems = 4;
            this.cmbNereye.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(121, 49);
            this.cmbNereye.StartIndex = 0;
            this.cmbNereye.TabIndex = 14;
            // 
            // cmbNereden
            // 
            this.cmbNereden.AutoResize = false;
            this.cmbNereden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbNereden.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbNereden.Depth = 0;
            this.cmbNereden.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbNereden.DropDownHeight = 174;
            this.cmbNereden.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNereden.DropDownWidth = 121;
            this.cmbNereden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbNereden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbNereden.FormattingEnabled = true;
            this.cmbNereden.Hint = "Nereden";
            this.cmbNereden.IntegralHeight = false;
            this.cmbNereden.ItemHeight = 43;
            this.cmbNereden.Items.AddRange(new object[] {
            "Van",
            "Ankara",
            "İzmir",
            "İstanbul"});
            this.cmbNereden.Location = new System.Drawing.Point(157, 348);
            this.cmbNereden.MaxDropDownItems = 4;
            this.cmbNereden.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(121, 49);
            this.cmbNereden.StartIndex = 0;
            this.cmbNereden.TabIndex = 13;
            // 
            // btnGidisDonus
            // 
            this.btnGidisDonus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGidisDonus.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGidisDonus.Depth = 0;
            this.btnGidisDonus.HighEmphasis = true;
            this.btnGidisDonus.Icon = null;
            this.btnGidisDonus.Location = new System.Drawing.Point(482, 268);
            this.btnGidisDonus.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGidisDonus.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGidisDonus.Name = "btnGidisDonus";
            this.btnGidisDonus.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnGidisDonus.Size = new System.Drawing.Size(119, 36);
            this.btnGidisDonus.TabIndex = 12;
            this.btnGidisDonus.Text = "Gidiş - Dönüş";
            this.btnGidisDonus.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGidisDonus.UseAccentColor = false;
            this.btnGidisDonus.UseVisualStyleBackColor = true;
            // 
            // btnTekYön
            // 
            this.btnTekYön.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTekYön.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnTekYön.Depth = 0;
            this.btnTekYön.HighEmphasis = true;
            this.btnTekYön.Icon = null;
            this.btnTekYön.Location = new System.Drawing.Point(393, 268);
            this.btnTekYön.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTekYön.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTekYön.Name = "btnTekYön";
            this.btnTekYön.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnTekYön.Size = new System.Drawing.Size(81, 36);
            this.btnTekYön.TabIndex = 11;
            this.btnTekYön.Text = "Tek Yön";
            this.btnTekYön.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.btnTekYön.UseAccentColor = false;
            this.btnTekYön.UseVisualStyleBackColor = true;
            this.btnTekYön.Click += new System.EventHandler(this.btnTekYön_Click);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBaslik.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(6, 205);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(263, 23);
            this.lblBaslik.TabIndex = 10;
            this.lblBaslik.Text = "Nereye Seyahat Etmek İstersiniz?";
            // 
            // lblMrb
            // 
            this.lblMrb.AutoSize = true;
            this.lblMrb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMrb.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMrb.Location = new System.Drawing.Point(6, 182);
            this.lblMrb.Name = "lblMrb";
            this.lblMrb.Size = new System.Drawing.Size(82, 23);
            this.lblMrb.TabIndex = 9;
            this.lblMrb.Text = "Merhaba,";
            // 
            // dtpDonus
            // 
            this.dtpDonus.CalendarFont = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDonus.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpDonus.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtpDonus.CalendarTitleBackColor = System.Drawing.Color.Aqua;
            this.dtpDonus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpDonus.Location = new System.Drawing.Point(394, 464);
            this.dtpDonus.Name = "dtpDonus";
            this.dtpDonus.Size = new System.Drawing.Size(245, 27);
            this.dtpDonus.TabIndex = 18;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(0, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(1, 0);
            this.materialLabel1.TabIndex = 19;
            // 
            // lblGidis
            // 
            this.lblGidis.AutoSize = true;
            this.lblGidis.BackColor = System.Drawing.Color.Transparent;
            this.lblGidis.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGidis.Location = new System.Drawing.Point(390, 342);
            this.lblGidis.Name = "lblGidis";
            this.lblGidis.Size = new System.Drawing.Size(101, 23);
            this.lblGidis.TabIndex = 20;
            this.lblGidis.Text = "Gidiş Tarihi";
            // 
            // lblDonus
            // 
            this.lblDonus.AutoSize = true;
            this.lblDonus.BackColor = System.Drawing.Color.Transparent;
            this.lblDonus.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDonus.Location = new System.Drawing.Point(390, 438);
            this.lblDonus.Name = "lblDonus";
            this.lblDonus.Size = new System.Drawing.Size(110, 23);
            this.lblDonus.TabIndex = 21;
            this.lblDonus.Text = "Dönüş Tarihi";
            // 
            // pbKullaniciFoto
            // 
            this.pbKullaniciFoto.Location = new System.Drawing.Point(8, 7);
            this.pbKullaniciFoto.Name = "pbKullaniciFoto";
            this.pbKullaniciFoto.Size = new System.Drawing.Size(45, 43);
            this.pbKullaniciFoto.TabIndex = 34;
            this.pbKullaniciFoto.TabStop = false;
            // 
            // btnKullaniciProfili
            // 
            this.btnKullaniciProfili.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnKullaniciProfili.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnKullaniciProfili.Depth = 0;
            this.btnKullaniciProfili.HighEmphasis = true;
            this.btnKullaniciProfili.Icon = null;
            this.btnKullaniciProfili.Location = new System.Drawing.Point(56, 11);
            this.btnKullaniciProfili.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnKullaniciProfili.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnKullaniciProfili.Name = "btnKullaniciProfili";
            this.btnKullaniciProfili.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnKullaniciProfili.Size = new System.Drawing.Size(122, 36);
            this.btnKullaniciProfili.TabIndex = 33;
            this.btnKullaniciProfili.Text = "Kullanıcı Adı";
            this.btnKullaniciProfili.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnKullaniciProfili.UseAccentColor = false;
            this.btnKullaniciProfili.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::nissAIR_Uygulaması.Properties.Resources.bildrim;
            this.pictureBox1.Location = new System.Drawing.Point(227, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // btnCheckIn
            // 
            this.btnCheckIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCheckIn.Depth = 0;
            this.btnCheckIn.HighEmphasis = true;
            this.btnCheckIn.Icon = null;
            this.btnCheckIn.Location = new System.Drawing.Point(397, 11);
            this.btnCheckIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCheckIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheckIn.Name = "btnCheckIn";
            this.btnCheckIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCheckIn.Size = new System.Drawing.Size(127, 36);
            this.btnCheckIn.TabIndex = 31;
            this.btnCheckIn.Text = "Hızlı Check-In";
            this.btnCheckIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCheckIn.UseAccentColor = false;
            this.btnCheckIn.UseVisualStyleBackColor = true;
            this.btnCheckIn.Click += new System.EventHandler(this.btnCheckIn_Click);
            // 
            // btnRehber
            // 
            this.btnRehber.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRehber.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRehber.Depth = 0;
            this.btnRehber.HighEmphasis = true;
            this.btnRehber.Icon = null;
            this.btnRehber.Location = new System.Drawing.Point(277, 11);
            this.btnRehber.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRehber.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRehber.Name = "btnRehber";
            this.btnRehber.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRehber.Size = new System.Drawing.Size(112, 36);
            this.btnRehber.TabIndex = 30;
            this.btnRehber.Text = "Niss Rehber";
            this.btnRehber.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRehber.UseAccentColor = false;
            this.btnRehber.UseVisualStyleBackColor = true;
            // 
            // anasayfaGD
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.anasayfa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 585);
            this.Controls.Add(this.pbKullaniciFoto);
            this.Controls.Add(this.btnKullaniciProfili);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCheckIn);
            this.Controls.Add(this.btnRehber);
            this.Controls.Add(this.lblDonus);
            this.Controls.Add(this.lblGidis);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dtpDonus);
            this.Controls.Add(this.btnUcusAra);
            this.Controls.Add(this.dtpGidis);
            this.Controls.Add(this.cmbYolcular);
            this.Controls.Add(this.cmbNereye);
            this.Controls.Add(this.cmbNereden);
            this.Controls.Add(this.btnGidisDonus);
            this.Controls.Add(this.btnTekYön);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblMrb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "anasayfaGD";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "anasayfaGD";
            ((System.ComponentModel.ISupportInitialize)(this.pbKullaniciFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btnUcusAra;
        private System.Windows.Forms.DateTimePicker dtpGidis;
        private MaterialSkin.Controls.MaterialComboBox cmbYolcular;
        private MaterialSkin.Controls.MaterialComboBox cmbNereye;
        private MaterialSkin.Controls.MaterialComboBox cmbNereden;
        private MaterialSkin.Controls.MaterialButton btnGidisDonus;
        private MaterialSkin.Controls.MaterialButton btnTekYön;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblMrb;
        private System.Windows.Forms.DateTimePicker dtpDonus;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label lblGidis;
        private System.Windows.Forms.Label lblDonus;
        private System.Windows.Forms.PictureBox pbKullaniciFoto;
        private MaterialSkin.Controls.MaterialButton btnKullaniciProfili;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton btnCheckIn;
        private MaterialSkin.Controls.MaterialButton btnRehber;
    }
}