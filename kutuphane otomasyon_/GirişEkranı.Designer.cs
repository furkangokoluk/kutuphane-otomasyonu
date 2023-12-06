namespace kutuphane_otomasyon_
{
    partial class GirisEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkranı));
            this.GirisYapBtn = new System.Windows.Forms.Button();
            this.YeniKullanıcıBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GirisYapBtn
            // 
            this.GirisYapBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.GirisYapBtn.FlatAppearance.BorderSize = 0;
            this.GirisYapBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GirisYapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisYapBtn.ForeColor = System.Drawing.Color.Teal;
            this.GirisYapBtn.Location = new System.Drawing.Point(26, 275);
            this.GirisYapBtn.Name = "GirisYapBtn";
            this.GirisYapBtn.Size = new System.Drawing.Size(170, 50);
            this.GirisYapBtn.TabIndex = 1;
            this.GirisYapBtn.Text = "Giriş Yap";
            this.GirisYapBtn.UseVisualStyleBackColor = false;
            this.GirisYapBtn.Click += new System.EventHandler(this.GirisYapBtn_Click);
            // 
            // YeniKullanıcıBtn
            // 
            this.YeniKullanıcıBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.YeniKullanıcıBtn.FlatAppearance.BorderSize = 0;
            this.YeniKullanıcıBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.YeniKullanıcıBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YeniKullanıcıBtn.ForeColor = System.Drawing.Color.Black;
            this.YeniKullanıcıBtn.Location = new System.Drawing.Point(196, 275);
            this.YeniKullanıcıBtn.Name = "YeniKullanıcıBtn";
            this.YeniKullanıcıBtn.Size = new System.Drawing.Size(170, 50);
            this.YeniKullanıcıBtn.TabIndex = 2;
            this.YeniKullanıcıBtn.Text = "Hesap Oluştur";
            this.YeniKullanıcıBtn.UseVisualStyleBackColor = false;
            this.YeniKullanıcıBtn.Click += new System.EventHandler(this.YeniKullanıcıBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(26, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 220);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(80, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // GirisEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(405, 559);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GirisYapBtn);
            this.Controls.Add(this.YeniKullanıcıBtn);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GirisEkranı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Kütüphane Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GirisYapBtn;
        private System.Windows.Forms.Button YeniKullanıcıBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

