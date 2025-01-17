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
            this.lblBagajHakki = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.nudFazlaBagaj = new System.Windows.Forms.NumericUpDown();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudFazlaBagaj)).BeginInit();
            this.SuspendLayout();

            // lblBagajHakki
            this.lblBagajHakki.AutoSize = true;
            this.lblBagajHakki.BackColor = System.Drawing.Color.Transparent;
            this.lblBagajHakki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBagajHakki.Location = new System.Drawing.Point(321, 270);
            this.lblBagajHakki.Name = "lblBagajHakki";
            this.lblBagajHakki.Size = new System.Drawing.Size(0, 20);

            // lblTutar
            this.lblTutar.AutoSize = true;
            this.lblTutar.BackColor = System.Drawing.Color.Transparent;
            this.lblTutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar.Location = new System.Drawing.Point(920, 450);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(0, 20);

            // lblKullaniciAdi
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.BackColor = System.Drawing.Color.Transparent;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(65, 270);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(0, 20);

            // nudFazlaBagaj
            this.nudFazlaBagaj.Location = new System.Drawing.Point(50, 150);
            this.nudFazlaBagaj.Name = "nudFazlaBagaj";
            this.nudFazlaBagaj.Size = new System.Drawing.Size(120, 22);
            this.nudFazlaBagaj.Minimum = 0;
            this.nudFazlaBagaj.Maximum = 10;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 588);
            this.Controls.Add(this.lblBagajHakki);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.nudFazlaBagaj);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Name = "EkstraBagajHakki";
            this.Text = "Ekstra Bagaj Hakkı";
            ((System.ComponentModel.ISupportInitialize)(this.nudFazlaBagaj)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblBagajHakki;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.NumericUpDown nudFazlaBagaj;
        private System.Windows.Forms.Label lblKullaniciAdi;
    }
} 