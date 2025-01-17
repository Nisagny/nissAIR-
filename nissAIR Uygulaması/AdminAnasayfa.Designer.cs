namespace nissAIR_Uygulaması
{
    partial class AdminAnasayfa
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
            this.btnUcaklar = new System.Windows.Forms.Button();
            this.btnUcuslar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnUcaklar
            // 
            this.btnUcaklar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUcaklar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUcaklar.Location = new System.Drawing.Point(12, 130);
            this.btnUcaklar.Name = "btnUcaklar";
            this.btnUcaklar.Size = new System.Drawing.Size(1026, 72);
            this.btnUcaklar.TabIndex = 3;
            this.btnUcaklar.Text = "UÇAKLAR";
            this.btnUcaklar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUcaklar.UseVisualStyleBackColor = false;
            this.btnUcaklar.Click += new System.EventHandler(this.btnUcaklar_Click);
            // 
            // btnUcuslar
            // 
            this.btnUcuslar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUcuslar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUcuslar.Location = new System.Drawing.Point(12, 225);
            this.btnUcuslar.Name = "btnUcuslar";
            this.btnUcuslar.Size = new System.Drawing.Size(1026, 72);
            this.btnUcuslar.TabIndex = 4;
            this.btnUcuslar.Text = "UÇUŞLAR";
            this.btnUcuslar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUcuslar.UseVisualStyleBackColor = false;
            this.btnUcuslar.Click += new System.EventHandler(this.btnUcuslar_Click);
            // 
            // AdminAnasayfa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.AdminAnasayfa1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 588);
            this.Controls.Add(this.btnUcuslar);
            this.Controls.Add(this.btnUcaklar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AdminAnasayfa";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminAnasayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUcaklar;
        private System.Windows.Forms.Button btnUcuslar;
    }
}