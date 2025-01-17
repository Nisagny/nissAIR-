namespace nissAIR_Uygulaması
{
    partial class MessageBoxBilet
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
            this.btnBasic = new System.Windows.Forms.Button();
            this.btnFlex = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.BackColor = System.Drawing.Color.Transparent;
            this.lblFiyat.Location = new System.Drawing.Point(447, 35);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(28, 16);
            this.lblFiyat.TabIndex = 0;
            this.lblFiyat.Text = "250";
            // 
            // btnBasic
            // 
            this.btnBasic.Location = new System.Drawing.Point(519, 114);
            this.btnBasic.Name = "btnBasic";
            this.btnBasic.Size = new System.Drawing.Size(123, 22);
            this.btnBasic.TabIndex = 1;
            this.btnBasic.Text = "BASIC\'te Kal";
            this.btnBasic.UseVisualStyleBackColor = true;
            this.btnBasic.Click += new System.EventHandler(this.btnBasic_Click);
            // 
            // btnFlex
            // 
            this.btnFlex.BackColor = System.Drawing.Color.Gold;
            this.btnFlex.Location = new System.Drawing.Point(513, 142);
            this.btnFlex.Name = "btnFlex";
            this.btnFlex.Size = new System.Drawing.Size(132, 35);
            this.btnFlex.TabIndex = 2;
            this.btnFlex.Text = "FLEX\'e Yükselt";
            this.btnFlex.UseVisualStyleBackColor = false;
            this.btnFlex.Click += new System.EventHandler(this.btnFlex_Click);
            // 
            // MessageBoxBilet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.MessgaeBox1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(657, 189);
            this.Controls.Add(this.btnFlex);
            this.Controls.Add(this.btnBasic);
            this.Controls.Add(this.lblFiyat);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MessageBoxBilet";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxBilet";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button btnBasic;
        private System.Windows.Forms.Button btnFlex;
    }
}