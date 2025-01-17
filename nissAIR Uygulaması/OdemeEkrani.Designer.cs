namespace nissAIR_Uygulaması
{
    partial class OdemeEkrani
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
            this.gbOdeme = new System.Windows.Forms.GroupBox();
            this.txtCVV = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtSKT = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtKartSahibi = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtKartNumarasi = new MaterialSkin.Controls.MaterialTextBox2();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnCancel = new MaterialSkin.Controls.MaterialButton();
            this.btnSubmit = new MaterialSkin.Controls.MaterialButton();
            this.gbOdeme.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOdeme
            // 
            this.gbOdeme.BackColor = System.Drawing.Color.White;
            this.gbOdeme.Controls.Add(this.txtCVV);
            this.gbOdeme.Controls.Add(this.txtSKT);
            this.gbOdeme.Controls.Add(this.txtKartSahibi);
            this.gbOdeme.Controls.Add(this.txtKartNumarasi);
            this.gbOdeme.Controls.Add(this.cmbPaymentType);
            this.gbOdeme.Location = new System.Drawing.Point(357, 27);
            this.gbOdeme.Name = "gbOdeme";
            this.gbOdeme.Size = new System.Drawing.Size(369, 441);
            this.gbOdeme.TabIndex = 0;
            this.gbOdeme.TabStop = false;
            this.gbOdeme.Text = "Ödeme Ekranı";
            // 
            // txtCVV
            // 
            this.txtCVV.AnimateReadOnly = false;
            this.txtCVV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCVV.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCVV.Depth = 0;
            this.txtCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCVV.HideSelection = true;
            this.txtCVV.Hint = "CVV";
            this.txtCVV.LeadingIcon = null;
            this.txtCVV.Location = new System.Drawing.Point(60, 333);
            this.txtCVV.MaxLength = 32767;
            this.txtCVV.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.PasswordChar = '\0';
            this.txtCVV.PrefixSuffixText = null;
            this.txtCVV.ReadOnly = false;
            this.txtCVV.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCVV.SelectedText = "";
            this.txtCVV.SelectionLength = 0;
            this.txtCVV.SelectionStart = 0;
            this.txtCVV.ShortcutsEnabled = true;
            this.txtCVV.Size = new System.Drawing.Size(86, 48);
            this.txtCVV.TabIndex = 6;
            this.txtCVV.TabStop = false;
            this.txtCVV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCVV.TrailingIcon = null;
            this.txtCVV.UseSystemPasswordChar = false;
            // 
            // txtSKT
            // 
            this.txtSKT.AnimateReadOnly = false;
            this.txtSKT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSKT.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSKT.Depth = 0;
            this.txtSKT.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSKT.HideSelection = true;
            this.txtSKT.Hint = "Son KullanmaTarihi";
            this.txtSKT.LeadingIcon = null;
            this.txtSKT.Location = new System.Drawing.Point(60, 279);
            this.txtSKT.MaxLength = 32767;
            this.txtSKT.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSKT.Name = "txtSKT";
            this.txtSKT.PasswordChar = '\0';
            this.txtSKT.PrefixSuffixText = null;
            this.txtSKT.ReadOnly = false;
            this.txtSKT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSKT.SelectedText = "";
            this.txtSKT.SelectionLength = 0;
            this.txtSKT.SelectionStart = 0;
            this.txtSKT.ShortcutsEnabled = true;
            this.txtSKT.Size = new System.Drawing.Size(250, 48);
            this.txtSKT.TabIndex = 4;
            this.txtSKT.TabStop = false;
            this.txtSKT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSKT.TrailingIcon = null;
            this.txtSKT.UseSystemPasswordChar = false;
            // 
            // txtKartSahibi
            // 
            this.txtKartSahibi.AnimateReadOnly = false;
            this.txtKartSahibi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtKartSahibi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtKartSahibi.Depth = 0;
            this.txtKartSahibi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtKartSahibi.HideSelection = true;
            this.txtKartSahibi.Hint = "Kart Sahibinin Adı";
            this.txtKartSahibi.LeadingIcon = null;
            this.txtKartSahibi.Location = new System.Drawing.Point(60, 167);
            this.txtKartSahibi.MaxLength = 32767;
            this.txtKartSahibi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtKartSahibi.Name = "txtKartSahibi";
            this.txtKartSahibi.PasswordChar = '\0';
            this.txtKartSahibi.PrefixSuffixText = null;
            this.txtKartSahibi.ReadOnly = false;
            this.txtKartSahibi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKartSahibi.SelectedText = "";
            this.txtKartSahibi.SelectionLength = 0;
            this.txtKartSahibi.SelectionStart = 0;
            this.txtKartSahibi.ShortcutsEnabled = true;
            this.txtKartSahibi.Size = new System.Drawing.Size(250, 48);
            this.txtKartSahibi.TabIndex = 3;
            this.txtKartSahibi.TabStop = false;
            this.txtKartSahibi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKartSahibi.TrailingIcon = null;
            this.txtKartSahibi.UseSystemPasswordChar = false;
            // 
            // txtKartNumarasi
            // 
            this.txtKartNumarasi.AnimateReadOnly = false;
            this.txtKartNumarasi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtKartNumarasi.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtKartNumarasi.Depth = 0;
            this.txtKartNumarasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtKartNumarasi.HideSelection = true;
            this.txtKartNumarasi.Hint = " Kart Numarası";
            this.txtKartNumarasi.LeadingIcon = null;
            this.txtKartNumarasi.Location = new System.Drawing.Point(60, 221);
            this.txtKartNumarasi.MaxLength = 32767;
            this.txtKartNumarasi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtKartNumarasi.Name = "txtKartNumarasi";
            this.txtKartNumarasi.PasswordChar = '\0';
            this.txtKartNumarasi.PrefixSuffixText = null;
            this.txtKartNumarasi.ReadOnly = false;
            this.txtKartNumarasi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtKartNumarasi.SelectedText = "";
            this.txtKartNumarasi.SelectionLength = 0;
            this.txtKartNumarasi.SelectionStart = 0;
            this.txtKartNumarasi.ShortcutsEnabled = true;
            this.txtKartNumarasi.Size = new System.Drawing.Size(250, 48);
            this.txtKartNumarasi.TabIndex = 3;
            this.txtKartNumarasi.TabStop = false;
            this.txtKartNumarasi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtKartNumarasi.TrailingIcon = null;
            this.txtKartNumarasi.UseSystemPasswordChar = false;
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Visa",
            "MasterCard"});
            this.cmbPaymentType.Location = new System.Drawing.Point(60, 95);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(250, 24);
            this.cmbPaymentType.TabIndex = 2;
            this.cmbPaymentType.Text = "Ödeme Tipi Seçiniz";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnCancel.Depth = 0;
            this.btnCancel.HighEmphasis = true;
            this.btnCancel.Icon = null;
            this.btnCancel.Location = new System.Drawing.Point(565, 494);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnCancel.Size = new System.Drawing.Size(82, 36);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "İPTAL ET";
            this.btnCancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnCancel.UseAccentColor = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnSubmit.Depth = 0;
            this.btnSubmit.HighEmphasis = true;
            this.btnSubmit.Icon = null;
            this.btnSubmit.Location = new System.Drawing.Point(447, 494);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSubmit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnSubmit.Size = new System.Drawing.Size(78, 36);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Onayla";
            this.btnSubmit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnSubmit.UseAccentColor = false;
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // OdemeEkrani
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.sayfa1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 585);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbOdeme);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "OdemeEkrani";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OdemeEkrani";
            this.gbOdeme.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOdeme;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbPaymentType;
        private MaterialSkin.Controls.MaterialButton btnCancel;
        private MaterialSkin.Controls.MaterialButton btnSubmit;
        private MaterialSkin.Controls.MaterialTextBox2 txtKartSahibi;
        private MaterialSkin.Controls.MaterialTextBox2 txtKartNumarasi;
        private MaterialSkin.Controls.MaterialTextBox2 txtSKT;
        private MaterialSkin.Controls.MaterialTextBox2 txtCVV;
    }
}