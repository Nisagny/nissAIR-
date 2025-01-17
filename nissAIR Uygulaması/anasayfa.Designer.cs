namespace nissAIR_Uygulaması
{
    partial class anasayfa
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
            this.lblMrb = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.cmbNereye = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbYolcular = new MaterialSkin.Controls.MaterialComboBox();
            this.dtpGidisTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnUcusAra = new MaterialSkin.Controls.MaterialButton();
            this.lblGidis = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiKullanici = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtCheckIn = new System.Windows.Forms.ToolStripTextBox();
            this.uçuşlarımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbNereden = new MaterialSkin.Controls.MaterialComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMrb
            // 
            this.lblMrb.AutoSize = true;
            this.lblMrb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblMrb.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMrb.Location = new System.Drawing.Point(6, 174);
            this.lblMrb.Name = "lblMrb";
            this.lblMrb.Size = new System.Drawing.Size(82, 23);
            this.lblMrb.TabIndex = 0;
            this.lblMrb.Text = "Merhaba,";
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBaslik.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(6, 197);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(263, 23);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "Nereye Seyahat Etmek İstersiniz?";
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
            "Van",
            "İstanbul",
            "Ankara",
            "İzmir"});
            this.cmbNereye.Location = new System.Drawing.Point(383, 328);
            this.cmbNereye.MaxDropDownItems = 4;
            this.cmbNereye.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(293, 49);
            this.cmbNereye.StartIndex = 0;
            this.cmbNereye.TabIndex = 5;
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
            this.cmbYolcular.Location = new System.Drawing.Point(682, 328);
            this.cmbYolcular.MaxDropDownItems = 4;
            this.cmbYolcular.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbYolcular.Name = "cmbYolcular";
            this.cmbYolcular.Size = new System.Drawing.Size(180, 49);
            this.cmbYolcular.StartIndex = 0;
            this.cmbYolcular.TabIndex = 6;
            // 
            // dtpGidisTarihi
            // 
            this.dtpGidisTarihi.CalendarFont = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGidisTarihi.CalendarForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtpGidisTarihi.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption;
            this.dtpGidisTarihi.CalendarTitleBackColor = System.Drawing.Color.Aqua;
            this.dtpGidisTarihi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpGidisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpGidisTarihi.Location = new System.Drawing.Point(362, 451);
            this.dtpGidisTarihi.Name = "dtpGidisTarihi";
            this.dtpGidisTarihi.Size = new System.Drawing.Size(282, 27);
            this.dtpGidisTarihi.TabIndex = 7;
            // 
            // btnUcusAra
            // 
            this.btnUcusAra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUcusAra.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUcusAra.Depth = 0;
            this.btnUcusAra.HighEmphasis = true;
            this.btnUcusAra.Icon = null;
            this.btnUcusAra.Location = new System.Drawing.Point(905, 509);
            this.btnUcusAra.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUcusAra.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUcusAra.Name = "btnUcusAra";
            this.btnUcusAra.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUcusAra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUcusAra.Size = new System.Drawing.Size(91, 36);
            this.btnUcusAra.TabIndex = 8;
            this.btnUcusAra.Text = "Uçuş Ara";
            this.btnUcusAra.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUcusAra.UseAccentColor = false;
            this.btnUcusAra.UseVisualStyleBackColor = true;
            this.btnUcusAra.Click += new System.EventHandler(this.btnUcusAra_Click);
            // 
            // lblGidis
            // 
            this.lblGidis.AutoSize = true;
            this.lblGidis.BackColor = System.Drawing.Color.Transparent;
            this.lblGidis.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGidis.Location = new System.Drawing.Point(454, 425);
            this.lblGidis.Name = "lblGidis";
            this.lblGidis.Size = new System.Drawing.Size(101, 23);
            this.lblGidis.TabIndex = 21;
            this.lblGidis.Text = "Gidiş Tarihi";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiKullanici,
            this.tstxtCheckIn,
            this.uçuşlarımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 31);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiKullanici
            // 
            this.tsmiKullanici.BackColor = System.Drawing.Color.MistyRose;
            this.tsmiKullanici.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem});
            this.tsmiKullanici.Name = "tsmiKullanici";
            this.tsmiKullanici.Size = new System.Drawing.Size(58, 28);
            this.tsmiKullanici.Text = "Profil";
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // tstxtCheckIn
            // 
            this.tstxtCheckIn.BackColor = System.Drawing.Color.MistyRose;
            this.tstxtCheckIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstxtCheckIn.Name = "tstxtCheckIn";
            this.tstxtCheckIn.Size = new System.Drawing.Size(100, 28);
            this.tstxtCheckIn.Text = "Hızlı Check-In";
            this.tstxtCheckIn.Click += new System.EventHandler(this.tstxtCheckIn_Click);
            // 
            // uçuşlarımToolStripMenuItem
            // 
            this.uçuşlarımToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.uçuşlarımToolStripMenuItem.Name = "uçuşlarımToolStripMenuItem";
            this.uçuşlarımToolStripMenuItem.Size = new System.Drawing.Size(88, 28);
            this.uçuşlarımToolStripMenuItem.Text = "Uçuşlarım";
            this.uçuşlarımToolStripMenuItem.Click += new System.EventHandler(this.uçuşlarımToolStripMenuItem_Click);
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
            "İstanbul",
            "İzmir",
            "Ankara"});
            this.cmbNereden.Location = new System.Drawing.Point(34, 328);
            this.cmbNereden.MaxDropDownItems = 4;
            this.cmbNereden.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(332, 49);
            this.cmbNereden.StartIndex = 0;
            this.cmbNereden.TabIndex = 4;
            // 
            // anasayfa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.anasayfa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 585);
            this.Controls.Add(this.lblGidis);
            this.Controls.Add(this.btnUcusAra);
            this.Controls.Add(this.dtpGidisTarihi);
            this.Controls.Add(this.cmbYolcular);
            this.Controls.Add(this.cmbNereye);
            this.Controls.Add(this.cmbNereden);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lblMrb);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "anasayfa";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "anasayfa";
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMrb;
        private System.Windows.Forms.Label lblBaslik;
        private MaterialSkin.Controls.MaterialComboBox cmbNereye;
        private MaterialSkin.Controls.MaterialComboBox cmbYolcular;
        private MaterialSkin.Controls.MaterialButton btnUcusAra;
        private System.Windows.Forms.Label lblGidis;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiKullanici;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tstxtCheckIn;
        private System.Windows.Forms.ToolStripMenuItem uçuşlarımToolStripMenuItem;
        public System.Windows.Forms.DateTimePicker dtpGidisTarihi;
        private MaterialSkin.Controls.MaterialComboBox cmbNereden;
    }
}