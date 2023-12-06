namespace kutuphane_otomasyon_
{
    partial class UyeEkleDuzenle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeEkleDuzenle));
            this.adTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soyadTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kimliknoTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.telnoTxt = new System.Windows.Forms.TextBox();
            this.uyeekleBtn = new System.Windows.Forms.Button();
            this.uyeresimPb = new System.Windows.Forms.PictureBox();
            this.resimsecBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.uyeeklePB = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.uyeresimPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // adTxt
            // 
            this.adTxt.Location = new System.Drawing.Point(116, 251);
            this.adTxt.Name = "adTxt";
            this.adTxt.Size = new System.Drawing.Size(285, 22);
            this.adTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Soyadı :";
            // 
            // soyadTxt
            // 
            this.soyadTxt.Location = new System.Drawing.Point(116, 279);
            this.soyadTxt.Name = "soyadTxt";
            this.soyadTxt.Size = new System.Drawing.Size(285, 22);
            this.soyadTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kimlik No :";
            // 
            // kimliknoTxt
            // 
            this.kimliknoTxt.Location = new System.Drawing.Point(116, 307);
            this.kimliknoTxt.Name = "kimliknoTxt";
            this.kimliknoTxt.Size = new System.Drawing.Size(285, 22);
            this.kimliknoTxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefon No :";
            // 
            // telnoTxt
            // 
            this.telnoTxt.Location = new System.Drawing.Point(116, 335);
            this.telnoTxt.Name = "telnoTxt";
            this.telnoTxt.Size = new System.Drawing.Size(285, 22);
            this.telnoTxt.TabIndex = 4;
            // 
            // uyeekleBtn
            // 
            this.uyeekleBtn.Location = new System.Drawing.Point(116, 380);
            this.uyeekleBtn.Name = "uyeekleBtn";
            this.uyeekleBtn.Size = new System.Drawing.Size(285, 44);
            this.uyeekleBtn.TabIndex = 5;
            this.uyeekleBtn.Text = "Üye Ekle";
            this.uyeekleBtn.UseVisualStyleBackColor = true;
            this.uyeekleBtn.Click += new System.EventHandler(this.uyeekleBtn_Click);
            // 
            // uyeresimPb
            // 
            this.uyeresimPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uyeresimPb.Location = new System.Drawing.Point(116, 12);
            this.uyeresimPb.Name = "uyeresimPb";
            this.uyeresimPb.Size = new System.Drawing.Size(285, 208);
            this.uyeresimPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uyeresimPb.TabIndex = 6;
            this.uyeresimPb.TabStop = false;
            // 
            // resimsecBtn
            // 
            this.resimsecBtn.Location = new System.Drawing.Point(340, 197);
            this.resimsecBtn.Name = "resimsecBtn";
            this.resimsecBtn.Size = new System.Drawing.Size(61, 22);
            this.resimsecBtn.TabIndex = 7;
            this.resimsecBtn.Text = "Seç";
            this.resimsecBtn.UseVisualStyleBackColor = true;
            this.resimsecBtn.Click += new System.EventHandler(this.resimsecBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // uyeeklePB
            // 
            this.uyeeklePB.Location = new System.Drawing.Point(116, 380);
            this.uyeeklePB.Name = "uyeeklePB";
            this.uyeeklePB.Size = new System.Drawing.Size(285, 44);
            this.uyeeklePB.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.uyeeklePB.TabIndex = 8;
            this.uyeeklePB.Visible = false;
            // 
            // UyeEkleDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 448);
            this.Controls.Add(this.uyeeklePB);
            this.Controls.Add(this.resimsecBtn);
            this.Controls.Add(this.uyeresimPb);
            this.Controls.Add(this.uyeekleBtn);
            this.Controls.Add(this.kimliknoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.soyadTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telnoTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adTxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UyeEkleDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Ekle";
            ((System.ComponentModel.ISupportInitialize)(this.uyeresimPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button resimsecBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        public System.Windows.Forms.TextBox adTxt;
        public System.Windows.Forms.TextBox soyadTxt;
        public System.Windows.Forms.TextBox kimliknoTxt;
        public System.Windows.Forms.TextBox telnoTxt;
        public System.Windows.Forms.PictureBox uyeresimPb;
        public System.Windows.Forms.Button uyeekleBtn;
        private System.Windows.Forms.ProgressBar uyeeklePB;
    }
}