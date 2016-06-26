namespace winAjandaUygulamasiV2
{
    partial class Form1
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
            this.lstEtkinlikler = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYeniToplanti = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYeniBulusma = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuYeniGorev = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstEtkinlikler
            // 
            this.lstEtkinlikler.FormattingEnabled = true;
            this.lstEtkinlikler.ItemHeight = 23;
            this.lstEtkinlikler.Location = new System.Drawing.Point(12, 27);
            this.lstEtkinlikler.Name = "lstEtkinlikler";
            this.lstEtkinlikler.Size = new System.Drawing.Size(408, 234);
            this.lstEtkinlikler.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(643, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYeniToplanti,
            this.mnuYeniBulusma,
            this.mnuYeniGorev});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // mnuYeniToplanti
            // 
            this.mnuYeniToplanti.Name = "mnuYeniToplanti";
            this.mnuYeniToplanti.Size = new System.Drawing.Size(146, 22);
            this.mnuYeniToplanti.Text = "Yeni Toplantı";
            this.mnuYeniToplanti.Click += new System.EventHandler(this.mnuYeniToplanti_Click);
            // 
            // mnuYeniBulusma
            // 
            this.mnuYeniBulusma.Name = "mnuYeniBulusma";
            this.mnuYeniBulusma.Size = new System.Drawing.Size(146, 22);
            this.mnuYeniBulusma.Text = "Yeni Buluşma";
            this.mnuYeniBulusma.Click += new System.EventHandler(this.mnuYeniBulusma_Click);
            // 
            // mnuYeniGorev
            // 
            this.mnuYeniGorev.Name = "mnuYeniGorev";
            this.mnuYeniGorev.Size = new System.Drawing.Size(146, 22);
            this.mnuYeniGorev.Text = "Yeni Görev";
            this.mnuYeniGorev.Click += new System.EventHandler(this.mnuYeniGorev_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(331, 267);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(89, 37);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(236, 267);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(89, 37);
            this.btnDuzenle.TabIndex = 2;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 316);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lstEtkinlikler);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Ajanda Uygulaması V2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstEtkinlikler;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuYeniToplanti;
        private System.Windows.Forms.ToolStripMenuItem mnuYeniBulusma;
        private System.Windows.Forms.ToolStripMenuItem mnuYeniGorev;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnDuzenle;
    }
}

