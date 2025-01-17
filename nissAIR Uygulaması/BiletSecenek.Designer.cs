namespace nissAIR_Uygulaması
{
    partial class BiletSecenek
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
            this.lblBasicFiyat = new System.Windows.Forms.Label();
            this.lblFlexFiyat = new System.Windows.Forms.Label();
            this.lblPremiumFiyat = new System.Windows.Forms.Label();
            this.btnFlex = new System.Windows.Forms.Button();
            this.btnPremium = new System.Windows.Forms.Button();
            this.btnBasic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBasicFiyat
            // 
            this.lblBasicFiyat.AutoSize = true;
            this.lblBasicFiyat.Location = new System.Drawing.Point(355, 210);
            this.lblBasicFiyat.Name = "lblBasicFiyat";
            this.lblBasicFiyat.Size = new System.Drawing.Size(0, 16);
            this.lblBasicFiyat.TabIndex = 4;
            // 
            // lblFlexFiyat
            // 
            this.lblFlexFiyat.AutoSize = true;
            this.lblFlexFiyat.Location = new System.Drawing.Point(290, 377);
            this.lblFlexFiyat.Name = "lblFlexFiyat";
            this.lblFlexFiyat.Size = new System.Drawing.Size(59, 16);
            this.lblFlexFiyat.TabIndex = 5;
            this.lblFlexFiyat.Text = "250 TRY";
            // 
            // lblPremiumFiyat
            // 
            this.lblPremiumFiyat.AutoSize = true;
            this.lblPremiumFiyat.Location = new System.Drawing.Point(290, 564);
            this.lblPremiumFiyat.Name = "lblPremiumFiyat";
            this.lblPremiumFiyat.Size = new System.Drawing.Size(59, 16);
            this.lblPremiumFiyat.TabIndex = 6;
            this.lblPremiumFiyat.Text = "750 TRY";
            // 
            // btnFlex
            // 
            this.btnFlex.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.FlexButton;
            this.btnFlex.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFlex.Location = new System.Drawing.Point(100, 232);
            this.btnFlex.Name = "btnFlex";
            this.btnFlex.Size = new System.Drawing.Size(249, 162);
            this.btnFlex.TabIndex = 3;
            this.btnFlex.UseVisualStyleBackColor = true;
            this.btnFlex.Click += new System.EventHandler(this.btnFlex_Click);
            // 
            // btnPremium
            // 
            this.btnPremium.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.premiumButton;
            this.btnPremium.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPremium.Location = new System.Drawing.Point(100, 400);
            this.btnPremium.Name = "btnPremium";
            this.btnPremium.Size = new System.Drawing.Size(249, 180);
            this.btnPremium.TabIndex = 2;
            this.btnPremium.UseVisualStyleBackColor = true;
            this.btnPremium.Click += new System.EventHandler(this.btnPremium_Click);
            // 
            // btnBasic
            // 
            this.btnBasic.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.basicButtoon;
            this.btnBasic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBasic.Location = new System.Drawing.Point(100, 47);
            this.btnBasic.Name = "btnBasic";
            this.btnBasic.Size = new System.Drawing.Size(249, 179);
            this.btnBasic.TabIndex = 0;
            this.btnBasic.UseVisualStyleBackColor = true;
            this.btnBasic.Click += new System.EventHandler(this.btnBasic_Click);
            // 
            // BiletSecenek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(454, 608);
            this.Controls.Add(this.lblPremiumFiyat);
            this.Controls.Add(this.lblFlexFiyat);
            this.Controls.Add(this.lblBasicFiyat);
            this.Controls.Add(this.btnFlex);
            this.Controls.Add(this.btnPremium);
            this.Controls.Add(this.btnBasic);
            this.Name = "BiletSecenek";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "button";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasic;
        private System.Windows.Forms.Button btnPremium;
        private System.Windows.Forms.Button btnFlex;
        private System.Windows.Forms.Label lblBasicFiyat;
        private System.Windows.Forms.Label lblFlexFiyat;
        private System.Windows.Forms.Label lblPremiumFiyat;
    }
}