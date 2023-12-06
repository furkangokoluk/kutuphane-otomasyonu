namespace kutuphane_otomasyon_
{
    partial class KitaplariGor
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
            this.kitapgörMs = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitaplisteleDgw = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.kitapgörMs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplisteleDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // kitapgörMs
            // 
            this.kitapgörMs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.kitapgörMs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.kitapgörMs.Name = "kitapgörMs";
            this.kitapgörMs.Size = new System.Drawing.Size(133, 52);
            this.kitapgörMs.Opening += new System.ComponentModel.CancelEventHandler(this.kitapgörMs_Opening);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // kitaplisteleDgw
            // 
            this.kitaplisteleDgw.AllowUserToAddRows = false;
            this.kitaplisteleDgw.AllowUserToDeleteRows = false;
            this.kitaplisteleDgw.BackgroundColor = System.Drawing.SystemColors.Control;
            this.kitaplisteleDgw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kitaplisteleDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplisteleDgw.ContextMenuStrip = this.kitapgörMs;
            this.kitaplisteleDgw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.kitaplisteleDgw.Location = new System.Drawing.Point(12, 40);
            this.kitaplisteleDgw.Name = "kitaplisteleDgw";
            this.kitaplisteleDgw.RowHeadersWidth = 51;
            this.kitaplisteleDgw.RowTemplate.Height = 24;
            this.kitaplisteleDgw.Size = new System.Drawing.Size(338, 391);
            this.kitaplisteleDgw.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mevcut Kitaplar :";
            // 
            // KitaplariGor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 493);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kitaplisteleDgw);
            this.Name = "KitaplariGor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KitaplariGor";
            this.kitapgörMs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kitaplisteleDgw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip kitapgörMs;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        public System.Windows.Forms.DataGridView kitaplisteleDgw;
        private System.Windows.Forms.Label label1;
    }
}