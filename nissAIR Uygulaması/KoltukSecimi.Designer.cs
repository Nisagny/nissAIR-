namespace nissAIR_Uygulaması
{
    partial class KoltukSecimi
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
            this.txtKoltukno = new System.Windows.Forms.TextBox();
            this.cmbKoltuk = new System.Windows.Forms.ComboBox();
            this.lblKoltukFiyat = new System.Windows.Forms.Label();
            this.btnDevam = new System.Windows.Forms.Button();
            this.linklblDevamEt = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txtKoltukno
            // 
            this.txtKoltukno.Location = new System.Drawing.Point(379, 415);
            this.txtKoltukno.Margin = new System.Windows.Forms.Padding(4);
            this.txtKoltukno.Name = "txtKoltukno";
            this.txtKoltukno.Size = new System.Drawing.Size(132, 22);
            this.txtKoltukno.TabIndex = 0;
            // 
            // cmbKoltuk
            // 
            this.cmbKoltuk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKoltuk.FormattingEnabled = true;
            this.cmbKoltuk.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.cmbKoltuk.Location = new System.Drawing.Point(525, 415);
            this.cmbKoltuk.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKoltuk.Name = "cmbKoltuk";
            this.cmbKoltuk.Size = new System.Drawing.Size(132, 24);
            this.cmbKoltuk.TabIndex = 1;
            // 
            // lblKoltukFiyat
            // 
            this.lblKoltukFiyat.AutoSize = true;
            this.lblKoltukFiyat.BackColor = System.Drawing.Color.Transparent;
            this.lblKoltukFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKoltukFiyat.Location = new System.Drawing.Point(916, 394);
            this.lblKoltukFiyat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKoltukFiyat.Name = "lblKoltukFiyat";
            this.lblKoltukFiyat.Size = new System.Drawing.Size(77, 20);
            this.lblKoltukFiyat.TabIndex = 2;
            this.lblKoltukFiyat.Text = "0.00 TRY";
            // 
            // btnDevam
            // 
            this.btnDevam.Location = new System.Drawing.Point(954, 513);
            this.btnDevam.Margin = new System.Windows.Forms.Padding(4);
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.Size = new System.Drawing.Size(100, 28);
            this.btnDevam.TabIndex = 3;
            this.btnDevam.Text = "Devam";
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // linklblDevamEt
            // 
            this.linklblDevamEt.ActiveLinkColor = System.Drawing.Color.RoyalBlue;
            this.linklblDevamEt.AutoSize = true;
            this.linklblDevamEt.BackColor = System.Drawing.Color.Transparent;
            this.linklblDevamEt.LinkColor = System.Drawing.Color.Black;
            this.linklblDevamEt.Location = new System.Drawing.Point(12, 9);
            this.linklblDevamEt.Name = "linklblDevamEt";
            this.linklblDevamEt.Size = new System.Drawing.Size(174, 16);
            this.linklblDevamEt.TabIndex = 4;
            this.linklblDevamEt.TabStop = true;
            this.linklblDevamEt.Text = "Koltuk Seçmeden Devam Et";
            this.linklblDevamEt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblDevamEt_LinkClicked);
            // 
            // KoltukSecimi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.Koltuk_Seçim;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.linklblDevamEt);
            this.Controls.Add(this.txtKoltukno);
            this.Controls.Add(this.cmbKoltuk);
            this.Controls.Add(this.lblKoltukFiyat);
            this.Controls.Add(this.btnDevam);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "KoltukSecimi";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Koltuk Seçimi";
            //this.Load += new System.EventHandler(this.KoltukSecimi_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKoltukno;
        private System.Windows.Forms.ComboBox cmbKoltuk;
        private System.Windows.Forms.Label lblKoltukFiyat;
        private System.Windows.Forms.Button btnDevam;
        private System.Windows.Forms.LinkLabel linklblDevamEt;
    }
}