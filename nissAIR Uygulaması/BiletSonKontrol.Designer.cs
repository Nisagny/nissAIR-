namespace nissAIR_Uygulaması
{
    partial class BiletSonKontrol
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
            this.lblKalkisSaat = new System.Windows.Forms.Label();
            this.lblKalkisYeri = new System.Windows.Forms.Label();
            this.lblVarisYeri = new System.Windows.Forms.Label();
            this.lblVarisSaat = new System.Windows.Forms.Label();
            this.btnDevam = new MaterialSkin.Controls.MaterialButton();
            this.lblTarih = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKalkisSaat
            // 
            this.lblKalkisSaat.AutoSize = true;
            this.lblKalkisSaat.BackColor = System.Drawing.Color.Transparent;
            this.lblKalkisSaat.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalkisSaat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKalkisSaat.Location = new System.Drawing.Point(231, 246);
            this.lblKalkisSaat.Name = "lblKalkisSaat";
            this.lblKalkisSaat.Size = new System.Drawing.Size(44, 23);
            this.lblKalkisSaat.TabIndex = 48;
            this.lblKalkisSaat.Text = "Saat";
            // 
            // lblKalkisYeri
            // 
            this.lblKalkisYeri.AutoSize = true;
            this.lblKalkisYeri.BackColor = System.Drawing.Color.Transparent;
            this.lblKalkisYeri.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKalkisYeri.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKalkisYeri.Location = new System.Drawing.Point(206, 287);
            this.lblKalkisYeri.Name = "lblKalkisYeri";
            this.lblKalkisYeri.Size = new System.Drawing.Size(100, 23);
            this.lblKalkisYeri.TabIndex = 50;
            this.lblKalkisYeri.Text = "Havalimanı";
            // 
            // lblVarisYeri
            // 
            this.lblVarisYeri.AutoSize = true;
            this.lblVarisYeri.BackColor = System.Drawing.Color.Transparent;
            this.lblVarisYeri.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVarisYeri.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVarisYeri.Location = new System.Drawing.Point(751, 287);
            this.lblVarisYeri.Name = "lblVarisYeri";
            this.lblVarisYeri.Size = new System.Drawing.Size(100, 23);
            this.lblVarisYeri.TabIndex = 53;
            this.lblVarisYeri.Text = "Havalimanı";
            // 
            // lblVarisSaat
            // 
            this.lblVarisSaat.AutoSize = true;
            this.lblVarisSaat.BackColor = System.Drawing.Color.Transparent;
            this.lblVarisSaat.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVarisSaat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblVarisSaat.Location = new System.Drawing.Point(782, 246);
            this.lblVarisSaat.Name = "lblVarisSaat";
            this.lblVarisSaat.Size = new System.Drawing.Size(44, 23);
            this.lblVarisSaat.TabIndex = 51;
            this.lblVarisSaat.Text = "Saat";
            // 
            // btnDevam
            // 
            this.btnDevam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDevam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDevam.Depth = 0;
            this.btnDevam.HighEmphasis = true;
            this.btnDevam.Icon = null;
            this.btnDevam.Location = new System.Drawing.Point(965, 534);
            this.btnDevam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDevam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDevam.Size = new System.Drawing.Size(71, 36);
            this.btnDevam.TabIndex = 54;
            this.btnDevam.Text = "DEVAM";
            this.btnDevam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDevam.UseAccentColor = false;
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.Transparent;
            this.lblTarih.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTarih.Location = new System.Drawing.Point(519, 175);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(51, 23);
            this.lblTarih.TabIndex = 55;
            this.lblTarih.Text = "Tarih";
            // 
            // BiletSonKontrol
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.BiletAlisSon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 585);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.lblVarisYeri);
            this.Controls.Add(this.lblVarisSaat);
            this.Controls.Add(this.lblKalkisYeri);
            this.Controls.Add(this.lblKalkisSaat);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BiletSonKontrol";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "BiletSonKontrol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblKalkisSaat;
        private System.Windows.Forms.Label lblKalkisYeri;
        private System.Windows.Forms.Label lblVarisYeri;
        private System.Windows.Forms.Label lblVarisSaat;
        private MaterialSkin.Controls.MaterialButton btnDevam;
        private System.Windows.Forms.Label lblTarih;
    }
}