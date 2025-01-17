namespace nissAIR_Uygulaması
{
    partial class AcilisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKullaniciGiris = new System.Windows.Forms.Button();
            this.btnAdminGirisi = new System.Windows.Forms.Button();
            this.lblkayıtOlBildirimi = new System.Windows.Forms.Label();
            this.btnkayitOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKullaniciGiris
            // 
            this.btnKullaniciGiris.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.btnKullaniciGiris;
            this.btnKullaniciGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKullaniciGiris.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnKullaniciGiris.FlatAppearance.BorderSize = 0;
            this.btnKullaniciGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnKullaniciGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnKullaniciGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKullaniciGiris.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKullaniciGiris.Location = new System.Drawing.Point(323, 248);
            this.btnKullaniciGiris.Name = "btnKullaniciGiris";
            this.btnKullaniciGiris.Size = new System.Drawing.Size(184, 180);
            this.btnKullaniciGiris.TabIndex = 0;
            this.btnKullaniciGiris.UseVisualStyleBackColor = true;
            this.btnKullaniciGiris.Click += new System.EventHandler(this.btnKullaniciGiris_Click);
            // 
            // btnAdminGirisi
            // 
            this.btnAdminGirisi.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.btnAdminGiris;
            this.btnAdminGirisi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminGirisi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAdminGirisi.FlatAppearance.BorderSize = 0;
            this.btnAdminGirisi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAdminGirisi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAdminGirisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminGirisi.Location = new System.Drawing.Point(524, 248);
            this.btnAdminGirisi.Name = "btnAdminGirisi";
            this.btnAdminGirisi.Size = new System.Drawing.Size(184, 180);
            this.btnAdminGirisi.TabIndex = 1;
            this.btnAdminGirisi.UseVisualStyleBackColor = true;
            this.btnAdminGirisi.Click += new System.EventHandler(this.btnAdminGirisi_Click);
            // 
            // lblkayıtOlBildirimi
            // 
            this.lblkayıtOlBildirimi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblkayıtOlBildirimi.BackColor = System.Drawing.Color.Transparent;
            this.lblkayıtOlBildirimi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblkayıtOlBildirimi.Font = new System.Drawing.Font("Palatino Linotype", 9.2F, System.Drawing.FontStyle.Bold);
            this.lblkayıtOlBildirimi.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblkayıtOlBildirimi.Location = new System.Drawing.Point(765, 553);
            this.lblkayıtOlBildirimi.Margin = new System.Windows.Forms.Padding(0);
            this.lblkayıtOlBildirimi.Name = "lblkayıtOlBildirimi";
            this.lblkayıtOlBildirimi.Size = new System.Drawing.Size(197, 22);
            this.lblkayıtOlBildirimi.TabIndex = 6;
            this.lblkayıtOlBildirimi.Text = "Bir hesabın yoksa hemen";
            this.lblkayıtOlBildirimi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnkayitOl
            // 
            this.btnkayitOl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnkayitOl.BackColor = System.Drawing.Color.Transparent;
            this.btnkayitOl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkayitOl.FlatAppearance.BorderSize = 0;
            this.btnkayitOl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnkayitOl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnkayitOl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkayitOl.Font = new System.Drawing.Font("Palatino Linotype", 9.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.btnkayitOl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnkayitOl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkayitOl.Location = new System.Drawing.Point(956, 546);
            this.btnkayitOl.Margin = new System.Windows.Forms.Padding(0);
            this.btnkayitOl.Name = "btnkayitOl";
            this.btnkayitOl.Size = new System.Drawing.Size(90, 36);
            this.btnkayitOl.TabIndex = 5;
            this.btnkayitOl.Text = "Kayıt Ol!";
            this.btnkayitOl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkayitOl.UseVisualStyleBackColor = false;
            this.btnkayitOl.Click += new System.EventHandler(this.btnkayitOl_Click);
            // 
            // AcilisEkrani
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 585);
            this.Controls.Add(this.lblkayıtOlBildirimi);
            this.Controls.Add(this.btnkayitOl);
            this.Controls.Add(this.btnAdminGirisi);
            this.Controls.Add(this.btnKullaniciGiris);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AcilisEkrani";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Açılış Ekranı";
            this.Load += new System.EventHandler(this.AcilisEkrani_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciGiris;
        private System.Windows.Forms.Button btnAdminGirisi;
        private System.Windows.Forms.Label lblkayıtOlBildirimi;
        private System.Windows.Forms.Button btnkayitOl;
    }
}

