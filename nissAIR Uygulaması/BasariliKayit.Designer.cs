namespace nissAIR_Uygulaması
{
    partial class BasariliKayit
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
            this.linklblAnasayfayaDon = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linklblAnasayfayaDon
            // 
            this.linklblAnasayfayaDon.ActiveLinkColor = System.Drawing.Color.DarkBlue;
            this.linklblAnasayfayaDon.AutoSize = true;
            this.linklblAnasayfayaDon.BackColor = System.Drawing.Color.Transparent;
            this.linklblAnasayfayaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linklblAnasayfayaDon.LinkColor = System.Drawing.Color.MidnightBlue;
            this.linklblAnasayfayaDon.Location = new System.Drawing.Point(828, 534);
            this.linklblAnasayfayaDon.Name = "linklblAnasayfayaDon";
            this.linklblAnasayfayaDon.Size = new System.Drawing.Size(215, 16);
            this.linklblAnasayfayaDon.TabIndex = 0;
            this.linklblAnasayfayaDon.TabStop = true;
            this.linklblAnasayfayaDon.Text = "Anasayfaya Dönmek İçin Tıklayınız";
            this.linklblAnasayfayaDon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblAnasayfayaDon_LinkClicked);
            // 
            // BasariliKayit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.kayıtBasarili;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 585);
            this.Controls.Add(this.linklblAnasayfayaDon);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BasariliKayit";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BasariliKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklblAnasayfayaDon;
    }
}