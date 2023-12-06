namespace kutuphane_otomasyon_
{
    partial class OduncVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OduncVer));
            this.uyeoduncDgw = new System.Windows.Forms.DataGridView();
            this.kitapoduncDgw = new System.Windows.Forms.DataGridView();
            this.oduncverBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.oduncuyenoTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.odunckitapTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.verilistrhTxt = new System.Windows.Forms.TextBox();
            this.teslimtrhTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uyeoduncDgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapoduncDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // uyeoduncDgw
            // 
            this.uyeoduncDgw.AllowUserToAddRows = false;
            this.uyeoduncDgw.AllowUserToDeleteRows = false;
            this.uyeoduncDgw.BackgroundColor = System.Drawing.SystemColors.Control;
            this.uyeoduncDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uyeoduncDgw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.uyeoduncDgw.Location = new System.Drawing.Point(31, 53);
            this.uyeoduncDgw.Name = "uyeoduncDgw";
            this.uyeoduncDgw.RowHeadersWidth = 51;
            this.uyeoduncDgw.RowTemplate.Height = 24;
            this.uyeoduncDgw.Size = new System.Drawing.Size(604, 220);
            this.uyeoduncDgw.TabIndex = 0;
            this.uyeoduncDgw.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.uyeoduncDgw_CellMouseClick);
            // 
            // kitapoduncDgw
            // 
            this.kitapoduncDgw.AllowUserToAddRows = false;
            this.kitapoduncDgw.AllowUserToDeleteRows = false;
            this.kitapoduncDgw.BackgroundColor = System.Drawing.SystemColors.Control;
            this.kitapoduncDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitapoduncDgw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kitapoduncDgw.Location = new System.Drawing.Point(31, 347);
            this.kitapoduncDgw.Name = "kitapoduncDgw";
            this.kitapoduncDgw.RowHeadersWidth = 51;
            this.kitapoduncDgw.RowTemplate.Height = 24;
            this.kitapoduncDgw.Size = new System.Drawing.Size(604, 208);
            this.kitapoduncDgw.TabIndex = 1;
            this.kitapoduncDgw.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.kitapoduncDgw_CellMouseClick);
            // 
            // oduncverBtn
            // 
            this.oduncverBtn.Location = new System.Drawing.Point(759, 452);
            this.oduncverBtn.Name = "oduncverBtn";
            this.oduncverBtn.Size = new System.Drawing.Size(200, 52);
            this.oduncverBtn.TabIndex = 5;
            this.oduncverBtn.Text = "Ödünç Ver";
            this.oduncverBtn.UseVisualStyleBackColor = true;
            this.oduncverBtn.Click += new System.EventHandler(this.oduncverBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Üye Kimlik No :";
            // 
            // oduncuyenoTxt
            // 
            this.oduncuyenoTxt.Location = new System.Drawing.Point(759, 201);
            this.oduncuyenoTxt.Name = "oduncuyenoTxt";
            this.oduncuyenoTxt.Size = new System.Drawing.Size(200, 22);
            this.oduncuyenoTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kitap Adı :";
            // 
            // odunckitapTxt
            // 
            this.odunckitapTxt.Location = new System.Drawing.Point(759, 251);
            this.odunckitapTxt.Name = "odunckitapTxt";
            this.odunckitapTxt.Size = new System.Drawing.Size(200, 22);
            this.odunckitapTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Veriliş Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(668, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teslim Tarihi :";
            // 
            // verilistrhTxt
            // 
            this.verilistrhTxt.Location = new System.Drawing.Point(765, 329);
            this.verilistrhTxt.Name = "verilistrhTxt";
            this.verilistrhTxt.Size = new System.Drawing.Size(194, 22);
            this.verilistrhTxt.TabIndex = 3;
            // 
            // teslimtrhTxt
            // 
            this.teslimtrhTxt.Location = new System.Drawing.Point(765, 379);
            this.teslimtrhTxt.Name = "teslimtrhTxt";
            this.teslimtrhTxt.Size = new System.Drawing.Size(194, 22);
            this.teslimtrhTxt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Üyeler :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(29, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kitaplar :";
            // 
            // OduncVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 600);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.teslimtrhTxt);
            this.Controls.Add(this.verilistrhTxt);
            this.Controls.Add(this.odunckitapTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oduncuyenoTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oduncverBtn);
            this.Controls.Add(this.kitapoduncDgw);
            this.Controls.Add(this.uyeoduncDgw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OduncVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Ver";
            ((System.ComponentModel.ISupportInitialize)(this.uyeoduncDgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitapoduncDgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView uyeoduncDgw;
        private System.Windows.Forms.DataGridView kitapoduncDgw;
        private System.Windows.Forms.Button oduncverBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox verilistrhTxt;
        private System.Windows.Forms.TextBox teslimtrhTxt;
        public System.Windows.Forms.TextBox oduncuyenoTxt;
        public System.Windows.Forms.TextBox odunckitapTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}