namespace nissAIR_Uygulaması
{
    partial class UcakTanimla
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
            this.dgvUcaklar = new System.Windows.Forms.DataGridView();
            this.btnUcakEkle = new MaterialSkin.Controls.MaterialButton();
            this.btnBaslangic = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcaklar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUcaklar
            // 
            this.dgvUcaklar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvUcaklar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvUcaklar.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvUcaklar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUcaklar.Location = new System.Drawing.Point(96, 168);
            this.dgvUcaklar.Name = "dgvUcaklar";
            this.dgvUcaklar.RowHeadersWidth = 51;
            this.dgvUcaklar.RowTemplate.Height = 24;
            this.dgvUcaklar.Size = new System.Drawing.Size(953, 302);
            this.dgvUcaklar.TabIndex = 3;
            // 
            // btnUcakEkle
            // 
            this.btnUcakEkle.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUcakEkle.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnUcakEkle.Depth = 0;
            this.btnUcakEkle.HighEmphasis = true;
            this.btnUcakEkle.Icon = null;
            this.btnUcakEkle.Location = new System.Drawing.Point(110, 490);
            this.btnUcakEkle.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUcakEkle.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUcakEkle.Name = "btnUcakEkle";
            this.btnUcakEkle.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnUcakEkle.Size = new System.Drawing.Size(97, 36);
            this.btnUcakEkle.TabIndex = 4;
            this.btnUcakEkle.Text = "Uçak ekle";
            this.btnUcakEkle.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnUcakEkle.UseAccentColor = false;
            this.btnUcakEkle.UseVisualStyleBackColor = true;
            this.btnUcakEkle.Click += new System.EventHandler(this.btnUcakEkle_Click);
            // 
            // btnBaslangic
            // 
            this.btnBaslangic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBaslangic.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBaslangic.Depth = 0;
            this.btnBaslangic.HighEmphasis = true;
            this.btnBaslangic.Icon = null;
            this.btnBaslangic.Location = new System.Drawing.Point(935, 15);
            this.btnBaslangic.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBaslangic.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBaslangic.Name = "btnBaslangic";
            this.btnBaslangic.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBaslangic.Size = new System.Drawing.Size(101, 36);
            this.btnBaslangic.TabIndex = 10;
            this.btnBaslangic.Text = "Başlangıç";
            this.btnBaslangic.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBaslangic.UseAccentColor = false;
            this.btnBaslangic.UseVisualStyleBackColor = true;
            this.btnBaslangic.Click += new System.EventHandler(this.btnBaslangic_Click);
            // 
            // UcakTanimla
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.UçakTanımlama;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 588);
            this.Controls.Add(this.btnBaslangic);
            this.Controls.Add(this.btnUcakEkle);
            this.Controls.Add(this.dgvUcaklar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "UcakTanimla";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UcakTanimla";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUcaklar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUcaklar;
        private MaterialSkin.Controls.MaterialButton btnUcakEkle;
        private MaterialSkin.Controls.MaterialButton btnBaslangic;
    }
}