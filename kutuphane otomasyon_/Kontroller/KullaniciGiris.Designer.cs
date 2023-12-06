namespace kutuphane_otomasyon_.Kontroller
{
    partial class KullaniciGiris
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.girisGosterCb = new System.Windows.Forms.CheckBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.girisPb = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "E-Mail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Şifre :";
            // 
            // emailTxt
            // 
            this.emailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailTxt.Location = new System.Drawing.Point(116, 50);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(195, 22);
            this.emailTxt.TabIndex = 1;
            this.emailTxt.Text = "Furkan.gklk@outlook.com\r\n";
            // 
            // sifreTxt
            // 
            this.sifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTxt.Location = new System.Drawing.Point(116, 78);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(195, 22);
            this.sifreTxt.TabIndex = 2;
            this.sifreTxt.Text = "Furkan123";
            // 
            // girisGosterCb
            // 
            this.girisGosterCb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.girisGosterCb.AutoSize = true;
            this.girisGosterCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisGosterCb.Location = new System.Drawing.Point(242, 106);
            this.girisGosterCb.Name = "girisGosterCb";
            this.girisGosterCb.Size = new System.Drawing.Size(69, 20);
            this.girisGosterCb.TabIndex = 3;
            this.girisGosterCb.Text = "Göster";
            this.girisGosterCb.UseVisualStyleBackColor = true;
            this.girisGosterCb.CheckedChanged += new System.EventHandler(this.gosterCb_CheckedChanged);
            // 
            // girisBtn
            // 
            this.girisBtn.ForeColor = System.Drawing.Color.Teal;
            this.girisBtn.Location = new System.Drawing.Point(116, 167);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(195, 37);
            this.girisBtn.TabIndex = 4;
            this.girisBtn.Text = "Giriş";
            this.girisBtn.UseVisualStyleBackColor = true;
            // 
            // girisPb
            // 
            this.girisPb.ForeColor = System.Drawing.Color.White;
            this.girisPb.Location = new System.Drawing.Point(116, 167);
            this.girisPb.Name = "girisPb";
            this.girisPb.Size = new System.Drawing.Size(195, 37);
            this.girisPb.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.girisPb.TabIndex = 5;
            this.girisPb.Visible = false;
            // 
            // KullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.girisPb);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.girisGosterCb);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KullaniciGiris";
            this.Size = new System.Drawing.Size(340, 220);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox girisGosterCb;
        public System.Windows.Forms.TextBox emailTxt;
        public System.Windows.Forms.TextBox sifreTxt;
        public System.Windows.Forms.Button girisBtn;
        public System.Windows.Forms.ProgressBar girisPb;
    }
}
