namespace nissAIR_Uygulaması
{
    partial class MessageBoxBilet2
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
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnFlex = new System.Windows.Forms.Button();
            this.btnPremium = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.BackColor = System.Drawing.Color.Transparent;
            this.lblFiyat.Location = new System.Drawing.Point(524, 33);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(28, 16);
            this.lblFiyat.TabIndex = 1;
            this.lblFiyat.Text = "750";
            // 
            // btnFlex
            // 
            this.btnFlex.Location = new System.Drawing.Point(605, 178);
            this.btnFlex.Name = "btnFlex";
            this.btnFlex.Size = new System.Drawing.Size(126, 22);
            this.btnFlex.TabIndex = 2;
            this.btnFlex.Text = "FLEX\'te Kal";
            this.btnFlex.UseVisualStyleBackColor = true;
            this.btnFlex.Click += new System.EventHandler(this.btnFlex_Click);
            // 
            // btnPremium
            // 
            this.btnPremium.BackColor = System.Drawing.Color.Gold;
            this.btnPremium.Location = new System.Drawing.Point(597, 207);
            this.btnPremium.Name = "btnPremium";
            this.btnPremium.Size = new System.Drawing.Size(141, 35);
            this.btnPremium.TabIndex = 3;
            this.btnPremium.Text = "PREMIUM\'a Yükselt";
            this.btnPremium.UseVisualStyleBackColor = false;
            this.btnPremium.Click += new System.EventHandler(this.btnPremium_Click);
            // 
            // MessageBoxBilet2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.MessageBox2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 258);
            this.Controls.Add(this.btnPremium);
            this.Controls.Add(this.btnFlex);
            this.Controls.Add(this.lblFiyat);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MessageBoxBilet2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxBilet2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button btnFlex;
        private System.Windows.Forms.Button btnPremium;
    }
}