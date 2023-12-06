namespace kutuphane_otomasyon_
{
    partial class OduncTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OduncTakip));
            this.odunctakipDgw = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.odunctakipDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // odunctakipDgw
            // 
            this.odunctakipDgw.AllowUserToAddRows = false;
            this.odunctakipDgw.AllowUserToDeleteRows = false;
            this.odunctakipDgw.BackgroundColor = System.Drawing.SystemColors.Control;
            this.odunctakipDgw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.odunctakipDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odunctakipDgw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.odunctakipDgw.Location = new System.Drawing.Point(22, 53);
            this.odunctakipDgw.Name = "odunctakipDgw";
            this.odunctakipDgw.RowHeadersWidth = 51;
            this.odunctakipDgw.RowTemplate.Height = 24;
            this.odunctakipDgw.Size = new System.Drawing.Size(615, 415);
            this.odunctakipDgw.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Verilen Ödünçler";
            // 
            // OduncTakip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odunctakipDgw);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OduncTakip";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ödünç Takip";
            ((System.ComponentModel.ISupportInitialize)(this.odunctakipDgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView odunctakipDgw;
        private System.Windows.Forms.Label label1;
    }
}