namespace kutuphane_otomasyon_
{
    partial class KitapEkleDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitapEkleDuzenle));
            this.label1 = new System.Windows.Forms.Label();
            this.kitaptürüTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kitapadıTxt = new System.Windows.Forms.TextBox();
            this.kitapekleBtn = new System.Windows.Forms.Button();
            this.kitapeklePb = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Türü :";
            // 
            // kitaptürüTxt
            // 
            this.kitaptürüTxt.Location = new System.Drawing.Point(107, 41);
            this.kitaptürüTxt.Name = "kitaptürüTxt";
            this.kitaptürüTxt.Size = new System.Drawing.Size(197, 22);
            this.kitaptürüTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitap Adı :";
            // 
            // kitapadıTxt
            // 
            this.kitapadıTxt.Location = new System.Drawing.Point(107, 69);
            this.kitapadıTxt.Name = "kitapadıTxt";
            this.kitapadıTxt.Size = new System.Drawing.Size(197, 22);
            this.kitapadıTxt.TabIndex = 2;
            // 
            // kitapekleBtn
            // 
            this.kitapekleBtn.Location = new System.Drawing.Point(107, 115);
            this.kitapekleBtn.Name = "kitapekleBtn";
            this.kitapekleBtn.Size = new System.Drawing.Size(197, 47);
            this.kitapekleBtn.TabIndex = 3;
            this.kitapekleBtn.Text = "Kitap Ekle";
            this.kitapekleBtn.UseVisualStyleBackColor = true;
            this.kitapekleBtn.Click += new System.EventHandler(this.kitapekleBtn_Click);
            // 
            // kitapeklePb
            // 
            this.kitapeklePb.Location = new System.Drawing.Point(107, 115);
            this.kitapeklePb.Name = "kitapeklePb";
            this.kitapeklePb.Size = new System.Drawing.Size(197, 47);
            this.kitapeklePb.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.kitapeklePb.TabIndex = 4;
            this.kitapeklePb.Visible = false;
            // 
            // KitapEkleDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 191);
            this.Controls.Add(this.kitapeklePb);
            this.Controls.Add(this.kitapekleBtn);
            this.Controls.Add(this.kitapadıTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kitaptürüTxt);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KitapEkleDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kitap Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox kitaptürüTxt;
        public System.Windows.Forms.TextBox kitapadıTxt;
        public System.Windows.Forms.Button kitapekleBtn;
        public System.Windows.Forms.ProgressBar kitapeklePb;
    }
}