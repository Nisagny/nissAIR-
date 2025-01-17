namespace nissAIR_Uygulaması
{
    partial class CheckIn
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
            this.txtPNR = new MaterialSkin.Controls.MaterialTextBox();
            this.txtSoyad = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnasayfa = new MaterialSkin.Controls.MaterialButton();
            this.btnDevam = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txtPNR
            // 
            this.txtPNR.AnimateReadOnly = false;
            this.txtPNR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPNR.Depth = 0;
            this.txtPNR.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPNR.Hint = "PNR No";
            this.txtPNR.LeadingIcon = null;
            this.txtPNR.Location = new System.Drawing.Point(391, 281);
            this.txtPNR.MaxLength = 50;
            this.txtPNR.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPNR.Multiline = false;
            this.txtPNR.Name = "txtPNR";
            this.txtPNR.Size = new System.Drawing.Size(201, 50);
            this.txtPNR.TabIndex = 0;
            this.txtPNR.Text = "";
            this.txtPNR.TrailingIcon = null;
            // 
            // txtSoyad
            // 
            this.txtSoyad.AnimateReadOnly = false;
            this.txtSoyad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSoyad.Depth = 0;
            this.txtSoyad.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSoyad.Hint = "Soyad";
            this.txtSoyad.LeadingIcon = null;
            this.txtSoyad.Location = new System.Drawing.Point(391, 367);
            this.txtSoyad.MaxLength = 50;
            this.txtSoyad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSoyad.Multiline = false;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(201, 50);
            this.txtSoyad.TabIndex = 1;
            this.txtSoyad.Text = "";
            this.txtSoyad.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "Check In";
            // 
            // btnAnasayfa
            // 
            this.btnAnasayfa.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnasayfa.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAnasayfa.Depth = 0;
            this.btnAnasayfa.HighEmphasis = true;
            this.btnAnasayfa.Icon = null;
            this.btnAnasayfa.Location = new System.Drawing.Point(26, 30);
            this.btnAnasayfa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAnasayfa.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnasayfa.Name = "btnAnasayfa";
            this.btnAnasayfa.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnAnasayfa.Size = new System.Drawing.Size(97, 36);
            this.btnAnasayfa.TabIndex = 36;
            this.btnAnasayfa.Text = "Anasayfa";
            this.btnAnasayfa.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAnasayfa.UseAccentColor = false;
            this.btnAnasayfa.UseVisualStyleBackColor = true;
            // 
            // btnDevam
            // 
            this.btnDevam.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDevam.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDevam.Depth = 0;
            this.btnDevam.HighEmphasis = true;
            this.btnDevam.Icon = null;
            this.btnDevam.Location = new System.Drawing.Point(945, 540);
            this.btnDevam.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDevam.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDevam.Name = "btnDevam";
            this.btnDevam.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDevam.Size = new System.Drawing.Size(71, 36);
            this.btnDevam.TabIndex = 37;
            this.btnDevam.Text = "Devam";
            this.btnDevam.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDevam.UseAccentColor = false;
            this.btnDevam.UseVisualStyleBackColor = true;
            this.btnDevam.Click += new System.EventHandler(this.btnDevam_Click);
            // 
            // CheckIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::nissAIR_Uygulaması.Properties.Resources.checkIn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 585);
            this.Controls.Add(this.btnDevam);
            this.Controls.Add(this.btnAnasayfa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtPNR);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CheckIn";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckIn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txtPNR;
        private MaterialSkin.Controls.MaterialTextBox txtSoyad;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnAnasayfa;
        private MaterialSkin.Controls.MaterialButton btnDevam;
    }
}