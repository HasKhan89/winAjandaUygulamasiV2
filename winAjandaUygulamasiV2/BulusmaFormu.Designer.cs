namespace winAjandaUygulamasiV2
{
    partial class BulusmaFormu
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
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnTamam = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKatilimci = new System.Windows.Forms.TextBox();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.dtpBasSaat = new System.Windows.Forms.DateTimePicker();
            this.dtpBasTar = new System.Windows.Forms.DateTimePicker();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(16, 116);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 14;
            this.btnIptal.Text = "Iptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(293, 116);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 15;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // txtKatilimci
            // 
            this.txtKatilimci.Location = new System.Drawing.Point(68, 64);
            this.txtKatilimci.Name = "txtKatilimci";
            this.txtKatilimci.Size = new System.Drawing.Size(192, 20);
            this.txtKatilimci.TabIndex = 8;
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(68, 38);
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(192, 20);
            this.txtNot.TabIndex = 9;
            // 
            // dtpBasSaat
            // 
            this.dtpBasSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBasSaat.Location = new System.Drawing.Point(274, 12);
            this.dtpBasSaat.Name = "dtpBasSaat";
            this.dtpBasSaat.Size = new System.Drawing.Size(94, 20);
            this.dtpBasSaat.TabIndex = 5;
            // 
            // dtpBasTar
            // 
            this.dtpBasTar.Location = new System.Drawing.Point(68, 12);
            this.dtpBasTar.Name = "dtpBasTar";
            this.dtpBasTar.Size = new System.Drawing.Size(200, 20);
            this.dtpBasTar.TabIndex = 7;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(212, 116);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDuzenle.TabIndex = 16;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // BulusmaFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 151);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKatilimci);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.dtpBasSaat);
            this.Controls.Add(this.dtpBasTar);
            this.Name = "BulusmaFormu";
            this.Text = "BulusmaFormu";
            this.Load += new System.EventHandler(this.BulusmaFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKatilimci;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.DateTimePicker dtpBasSaat;
        private System.Windows.Forms.DateTimePicker dtpBasTar;
        private System.Windows.Forms.Button btnDuzenle;
    }
}