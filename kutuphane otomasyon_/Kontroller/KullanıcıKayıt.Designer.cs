namespace kutuphane_otomasyon_.Kontroller
{
    partial class KullanıcıKayıt
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
            this.yeniGosterCb = new System.Windows.Forms.CheckBox();
            this.yeniSifreTxt = new System.Windows.Forms.TextBox();
            this.yeniEmailTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tyeniSifreTxt = new System.Windows.Forms.TextBox();
            this.tYeniGoster = new System.Windows.Forms.CheckBox();
            this.k_olusturBtn = new System.Windows.Forms.Button();
            this.kayitPb = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // yeniGosterCb
            // 
            this.yeniGosterCb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yeniGosterCb.AutoSize = true;
            this.yeniGosterCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniGosterCb.Location = new System.Drawing.Point(242, 77);
            this.yeniGosterCb.Name = "yeniGosterCb";
            this.yeniGosterCb.Size = new System.Drawing.Size(69, 20);
            this.yeniGosterCb.TabIndex = 3;
            this.yeniGosterCb.Text = "Göster";
            this.yeniGosterCb.UseVisualStyleBackColor = true;
            this.yeniGosterCb.CheckedChanged += new System.EventHandler(this.yeniGosterCb_CheckedChanged);
            // 
            // yeniSifreTxt
            // 
            this.yeniSifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniSifreTxt.Location = new System.Drawing.Point(115, 49);
            this.yeniSifreTxt.Name = "yeniSifreTxt";
            this.yeniSifreTxt.PasswordChar = '*';
            this.yeniSifreTxt.Size = new System.Drawing.Size(196, 22);
            this.yeniSifreTxt.TabIndex = 1;
            // 
            // yeniEmailTxt
            // 
            this.yeniEmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yeniEmailTxt.Location = new System.Drawing.Point(116, 21);
            this.yeniEmailTxt.Name = "yeniEmailTxt";
            this.yeniEmailTxt.Size = new System.Drawing.Size(195, 22);
            this.yeniEmailTxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(69, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "E-Mail :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(27, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre Tekrar :";
            // 
            // tyeniSifreTxt
            // 
            this.tyeniSifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tyeniSifreTxt.Location = new System.Drawing.Point(114, 103);
            this.tyeniSifreTxt.Name = "tyeniSifreTxt";
            this.tyeniSifreTxt.PasswordChar = '*';
            this.tyeniSifreTxt.Size = new System.Drawing.Size(197, 22);
            this.tyeniSifreTxt.TabIndex = 4;
            // 
            // tYeniGoster
            // 
            this.tYeniGoster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tYeniGoster.AutoSize = true;
            this.tYeniGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tYeniGoster.Location = new System.Drawing.Point(242, 131);
            this.tYeniGoster.Name = "tYeniGoster";
            this.tYeniGoster.Size = new System.Drawing.Size(69, 20);
            this.tYeniGoster.TabIndex = 5;
            this.tYeniGoster.Text = "Göster";
            this.tYeniGoster.UseVisualStyleBackColor = true;
            this.tYeniGoster.CheckedChanged += new System.EventHandler(this.tYeniGoster_CheckedChanged);
            // 
            // k_olusturBtn
            // 
            this.k_olusturBtn.BackColor = System.Drawing.SystemColors.Window;
            this.k_olusturBtn.ForeColor = System.Drawing.Color.Teal;
            this.k_olusturBtn.Location = new System.Drawing.Point(116, 167);
            this.k_olusturBtn.Name = "k_olusturBtn";
            this.k_olusturBtn.Size = new System.Drawing.Size(195, 37);
            this.k_olusturBtn.TabIndex = 10;
            this.k_olusturBtn.Text = "Kullanıcı Oluştur";
            this.k_olusturBtn.UseVisualStyleBackColor = false;
            // 
            // kayitPb
            // 
            this.kayitPb.Location = new System.Drawing.Point(116, 167);
            this.kayitPb.Name = "kayitPb";
            this.kayitPb.Size = new System.Drawing.Size(195, 37);
            this.kayitPb.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.kayitPb.TabIndex = 11;
            this.kayitPb.Visible = false;
            // 
            // KullanıcıKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.kayitPb);
            this.Controls.Add(this.k_olusturBtn);
            this.Controls.Add(this.tyeniSifreTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tYeniGoster);
            this.Controls.Add(this.yeniGosterCb);
            this.Controls.Add(this.yeniSifreTxt);
            this.Controls.Add(this.yeniEmailTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KullanıcıKayıt";
            this.Size = new System.Drawing.Size(340, 220);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox yeniGosterCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox tYeniGoster;
        public System.Windows.Forms.TextBox yeniSifreTxt;
        public System.Windows.Forms.TextBox yeniEmailTxt;
        public System.Windows.Forms.TextBox tyeniSifreTxt;
        public System.Windows.Forms.Button k_olusturBtn;
        public System.Windows.Forms.ProgressBar kayitPb;
    }
}
