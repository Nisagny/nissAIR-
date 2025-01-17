namespace nissAIR_Uygulaması
{
    partial class UcusTanimlama
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUcuslar = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.gbUcusInfo = new System.Windows.Forms.GroupBox();
            this.cmbNereye = new MaterialSkin.Controls.MaterialComboBox();
            this.lblVarisSaati = new System.Windows.Forms.Label();
            this.cmbNereden = new MaterialSkin.Controls.MaterialComboBox();
            this.lblVarisTarihi = new System.Windows.Forms.Label();
            this.dtpVarisSaati = new System.Windows.Forms.DateTimePicker();
            this.dtpVarisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblKalkisSaat = new System.Windows.Forms.Label();
            this.lblKalkisDate = new System.Windows.Forms.Label();
            this.dtpKalkisSaat = new System.Windows.Forms.DateTimePicker();
            this.dtpKalkisTarih = new System.Windows.Forms.DateTimePicker();
            this.txtUcret = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPlane = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtSearch = new MaterialSkin.Controls.MaterialTextBox();
            this.btnBaslangic = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcuslar)).BeginInit();
            this.gbUcusInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(394, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "UÇUŞLAR";
            // 
            // dgvUcuslar
            // 
            this.dgvUcuslar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvUcuslar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvUcuslar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUcuslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcuslar.Location = new System.Drawing.Point(468, 131);
            this.dgvUcuslar.Name = "dgvUcuslar";
            this.dgvUcuslar.RowHeadersWidth = 51;
            this.dgvUcuslar.RowTemplate.Height = 24;
            this.dgvUcuslar.Size = new System.Drawing.Size(575, 397);
            this.dgvUcuslar.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Location = new System.Drawing.Point(160, 545);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(144, 37);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Uçuş Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.Location = new System.Drawing.Point(544, 534);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(144, 37);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Uçuşu Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelle.Location = new System.Drawing.Point(813, 534);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(144, 37);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Uçuşu Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // gbUcusInfo
            // 
            this.gbUcusInfo.Controls.Add(this.cmbNereye);
            this.gbUcusInfo.Controls.Add(this.lblVarisSaati);
            this.gbUcusInfo.Controls.Add(this.cmbNereden);
            this.gbUcusInfo.Controls.Add(this.lblVarisTarihi);
            this.gbUcusInfo.Controls.Add(this.dtpVarisSaati);
            this.gbUcusInfo.Controls.Add(this.dtpVarisTarihi);
            this.gbUcusInfo.Controls.Add(this.lblKalkisSaat);
            this.gbUcusInfo.Controls.Add(this.lblKalkisDate);
            this.gbUcusInfo.Controls.Add(this.dtpKalkisSaat);
            this.gbUcusInfo.Controls.Add(this.dtpKalkisTarih);
            this.gbUcusInfo.Controls.Add(this.txtUcret);
            this.gbUcusInfo.Controls.Add(this.txtPlane);
            this.gbUcusInfo.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbUcusInfo.Location = new System.Drawing.Point(106, 131);
            this.gbUcusInfo.Name = "gbUcusInfo";
            this.gbUcusInfo.Size = new System.Drawing.Size(299, 397);
            this.gbUcusInfo.TabIndex = 6;
            this.gbUcusInfo.TabStop = false;
            this.gbUcusInfo.Text = "Uçuş Ekleyin";
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
            this.cmbNereye.Location = new System.Drawing.Point(22, 149);
            this.cmbNereye.MaxDropDownItems = 4;
            this.cmbNereye.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbNereye.Name = "cmbNereye";
            this.cmbNereye.Size = new System.Drawing.Size(250, 49);
            this.cmbNereye.StartIndex = 0;
            this.cmbNereye.TabIndex = 26;
            // 
            // lblVarisSaati
            // 
            this.lblVarisSaati.AutoSize = true;
            this.lblVarisSaati.Location = new System.Drawing.Point(171, 324);
            this.lblVarisSaati.Name = "lblVarisSaati";
            this.lblVarisSaati.Size = new System.Drawing.Size(89, 25);
            this.lblVarisSaati.TabIndex = 24;
            this.lblVarisSaati.Text = "Varış Saati";
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
            "Ankara",
            "İzmir"});
            this.cmbNereden.Location = new System.Drawing.Point(22, 94);
            this.cmbNereden.MaxDropDownItems = 4;
            this.cmbNereden.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbNereden.Name = "cmbNereden";
            this.cmbNereden.Size = new System.Drawing.Size(250, 49);
            this.cmbNereden.StartIndex = 0;
            this.cmbNereden.TabIndex = 25;
            // 
            // lblVarisTarihi
            // 
            this.lblVarisTarihi.AutoSize = true;
            this.lblVarisTarihi.Location = new System.Drawing.Point(36, 324);
            this.lblVarisTarihi.Name = "lblVarisTarihi";
            this.lblVarisTarihi.Size = new System.Drawing.Size(96, 25);
            this.lblVarisTarihi.TabIndex = 23;
            this.lblVarisTarihi.Text = "Varış Tarihi";
            // 
            // dtpVarisSaati
            // 
            this.dtpVarisSaati.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpVarisSaati.Location = new System.Drawing.Point(169, 352);
            this.dtpVarisSaati.Name = "dtpVarisSaati";
            this.dtpVarisSaati.Size = new System.Drawing.Size(106, 30);
            this.dtpVarisSaati.TabIndex = 22;
            // 
            // dtpVarisTarihi
            // 
            this.dtpVarisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVarisTarihi.Location = new System.Drawing.Point(25, 352);
            this.dtpVarisTarihi.Name = "dtpVarisTarihi";
            this.dtpVarisTarihi.Size = new System.Drawing.Size(118, 30);
            this.dtpVarisTarihi.TabIndex = 21;
            // 
            // lblKalkisSaat
            // 
            this.lblKalkisSaat.AutoSize = true;
            this.lblKalkisSaat.Location = new System.Drawing.Point(171, 253);
            this.lblKalkisSaat.Name = "lblKalkisSaat";
            this.lblKalkisSaat.Size = new System.Drawing.Size(97, 25);
            this.lblKalkisSaat.TabIndex = 20;
            this.lblKalkisSaat.Text = "Kalkış Saati";
            // 
            // lblKalkisDate
            // 
            this.lblKalkisDate.AutoSize = true;
            this.lblKalkisDate.Location = new System.Drawing.Point(36, 253);
            this.lblKalkisDate.Name = "lblKalkisDate";
            this.lblKalkisDate.Size = new System.Drawing.Size(104, 25);
            this.lblKalkisDate.TabIndex = 19;
            this.lblKalkisDate.Text = "Kalkış Tarihi";
            // 
            // dtpKalkisSaat
            // 
            this.dtpKalkisSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpKalkisSaat.Location = new System.Drawing.Point(169, 279);
            this.dtpKalkisSaat.Name = "dtpKalkisSaat";
            this.dtpKalkisSaat.Size = new System.Drawing.Size(106, 30);
            this.dtpKalkisSaat.TabIndex = 18;
            // 
            // dtpKalkisTarih
            // 
            this.dtpKalkisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKalkisTarih.Location = new System.Drawing.Point(25, 279);
            this.dtpKalkisTarih.Name = "dtpKalkisTarih";
            this.dtpKalkisTarih.Size = new System.Drawing.Size(118, 30);
            this.dtpKalkisTarih.TabIndex = 17;
            // 
            // txtUcret
            // 
            this.txtUcret.AnimateReadOnly = false;
            this.txtUcret.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUcret.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUcret.Depth = 0;
            this.txtUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUcret.HideSelection = true;
            this.txtUcret.Hint = "Taban Ücret";
            this.txtUcret.LeadingIcon = null;
            this.txtUcret.Location = new System.Drawing.Point(22, 202);
            this.txtUcret.MaxLength = 32767;
            this.txtUcret.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.PasswordChar = '\0';
            this.txtUcret.PrefixSuffixText = null;
            this.txtUcret.ReadOnly = false;
            this.txtUcret.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUcret.SelectedText = "";
            this.txtUcret.SelectionLength = 0;
            this.txtUcret.SelectionStart = 0;
            this.txtUcret.ShortcutsEnabled = true;
            this.txtUcret.Size = new System.Drawing.Size(250, 48);
            this.txtUcret.TabIndex = 16;
            this.txtUcret.TabStop = false;
            this.txtUcret.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUcret.TrailingIcon = null;
            this.txtUcret.UseSystemPasswordChar = false;
            // 
            // txtPlane
            // 
            this.txtPlane.AnimateReadOnly = false;
            this.txtPlane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPlane.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPlane.Depth = 0;
            this.txtPlane.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPlane.HideSelection = true;
            this.txtPlane.Hint = "Plane ID";
            this.txtPlane.LeadingIcon = null;
            this.txtPlane.Location = new System.Drawing.Point(22, 40);
            this.txtPlane.MaxLength = 32767;
            this.txtPlane.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPlane.Name = "txtPlane";
            this.txtPlane.PasswordChar = '\0';
            this.txtPlane.PrefixSuffixText = null;
            this.txtPlane.ReadOnly = false;
            this.txtPlane.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPlane.SelectedText = "";
            this.txtPlane.SelectionLength = 0;
            this.txtPlane.SelectionStart = 0;
            this.txtPlane.ShortcutsEnabled = true;
            this.txtPlane.Size = new System.Drawing.Size(250, 48);
            this.txtPlane.TabIndex = 1;
            this.txtPlane.TabStop = false;
            this.txtPlane.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPlane.TrailingIcon = null;
            this.txtPlane.UseSystemPasswordChar = false;
            // 
            // txtSearch
            // 
            this.txtSearch.AnimateReadOnly = false;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Hint = "Search";
            this.txtSearch.LeadingIcon = null;
            this.txtSearch.Location = new System.Drawing.Point(468, 75);
            this.txtSearch.MaxLength = 50;
            this.txtSearch.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(575, 50);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.Text = "";
            this.txtSearch.TrailingIcon = null;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnBaslangic
            // 
            this.btnBaslangic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBaslangic.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBaslangic.Depth = 0;
            this.btnBaslangic.HighEmphasis = true;
            this.btnBaslangic.Icon = null;
            this.btnBaslangic.Location = new System.Drawing.Point(884, 13);
            this.btnBaslangic.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBaslangic.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBaslangic.Name = "btnBaslangic";
            this.btnBaslangic.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaslangic.Size = new System.Drawing.Size(158, 36);
            this.btnBaslangic.TabIndex = 9;
            this.btnBaslangic.Text = "Başlangıç";
            this.btnBaslangic.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBaslangic.UseAccentColor = false;
            this.btnBaslangic.UseVisualStyleBackColor = true;
            this.btnBaslangic.Click += new System.EventHandler(this.btnBaslangic_Click);
            // 
            // UcusTanimlama
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.UçuşTanımlama;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 588);
            this.Controls.Add(this.btnBaslangic);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gbUcusInfo);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvUcuslar);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UcusTanimlama";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UcusTanimlama";
            this.Load += new System.EventHandler(this.UcusTanimlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcuslar)).EndInit();
            this.gbUcusInfo.ResumeLayout(false);
            this.gbUcusInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvUcuslar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.GroupBox gbUcusInfo;
        private MaterialSkin.Controls.MaterialTextBox2 txtPlane;
        private MaterialSkin.Controls.MaterialTextBox txtSearch;
        private System.Windows.Forms.Label lblVarisSaati;
        private System.Windows.Forms.Label lblVarisTarihi;
        private System.Windows.Forms.DateTimePicker dtpVarisSaati;
        private System.Windows.Forms.DateTimePicker dtpVarisTarihi;
        private System.Windows.Forms.Label lblKalkisSaat;
        private System.Windows.Forms.Label lblKalkisDate;
        private System.Windows.Forms.DateTimePicker dtpKalkisSaat;
        private System.Windows.Forms.DateTimePicker dtpKalkisTarih;
        private MaterialSkin.Controls.MaterialTextBox2 txtUcret;
        private MaterialSkin.Controls.MaterialComboBox cmbNereden;
        private MaterialSkin.Controls.MaterialComboBox cmbNereye;
        private MaterialSkin.Controls.MaterialButton btnBaslangic;
    }
}