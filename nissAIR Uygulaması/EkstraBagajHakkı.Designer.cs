namespace nissAIR_Uygulaması
{
    partial class EkstraBagajHakki
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblYolcu = new System.Windows.Forms.Label();
            this.lblBagajHakki = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.nudFazlaBagaj = new System.Windows.Forms.NumericUpDown();
            this.btnDevam = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudFazlaBagaj)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYolcu
            // 
            this.lblYolcu.AutoSize = true;
            this.lblYolcu.BackColor = System.Drawing.Color.Transparent;
            this.lblYolcu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYolcu.Location = new System.Drawing.Point(90, 280);
            this.lblYolcu.Name = "lblYolcu";
            this.lblYolcu.Size = new System.Drawing.Size(0, 20);
            this.lblYolcu.TabIndex = 0;
            // 
            // lblBagajHakki
            // 
            this.lblBagajHakki.AutoSize = true;
            this.lblBagajHakki.BackColor = System.Drawing.Color.Transparent;
            this.lblBagajHakki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBagajHakki.Location = new System.Drawing.Point(340, 280);
            this.lblBagajHakki.Name = "lblBagajHakki";
            this.lblBagajHakki.Size = new System.Drawing.Size(0, 20);
            this.lblBagajHakki.TabIndex = 1;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(890, 280);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(0, 20);
            this.lblTutar.TabIndex = 2;
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblToplamTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamTutar.Location = new System.Drawing.Point(920, 500);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(0, 20);
            this.lblToplamTutar.TabIndex = 3;
            // 
            // nudFazlaBagaj
            // 
            this.nudFazlaBagaj.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudFazlaBagaj.Location = new System.Drawing.Point(600, 270);
            this.nudFazlaBagaj.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudFazlaBagaj.Name = "nudFazlaBagaj";
            this.nudFazlaBagaj.Size = new System.Drawing.Size(120, 22);
            this.nudFazlaBagaj.TabIndex = 4;
            // 
            // btnDevam
            // 
            this.btnDevam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDevam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDevam.Depth = 0;
            this.btnDevam.HighEmphasis = true;
            this.btnDevam.Icon = null;
            this.btnDevam.Location = new System.Drawing.Point(965, 543);
            this.btnDevam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDevam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDevam.Size = new System.Drawing.Size(71, 36);
            this.btnDevam.TabIndex = 5;
            this.btnDevam.Text = "Devam";
            this.btnDevam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDevam.UseAccentColor = false;
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // EkstraBagajHakki
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.bagajHakki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 588);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.lblYolcu);
            this.Controls.Add(this.lblBagajHakki);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.nudFazlaBagaj);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EkstraBagajHakki";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekstra Bagaj Hakkı";
            this.Load += new System.EventHandler(this.EkstraBagajHakki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFazlaBagaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblYolcu;
        private System.Windows.Forms.Label lblBagajHakki;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.NumericUpDown nudFazlaBagaj;
        private MaterialSkin.Controls.MaterialButton btnDevam;
    }
}