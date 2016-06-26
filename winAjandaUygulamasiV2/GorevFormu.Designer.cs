namespace winAjandaUygulamasiV2
{
    partial class GorevFormu
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.dtpBasSaat = new System.Windows.Forms.DateTimePicker();
            this.dtpBasTar = new System.Windows.Forms.DateTimePicker();
            this.rdbYapildi = new System.Windows.Forms.RadioButton();
            this.rdbYapilacak = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(211, 116);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 23;
            this.btnIptal.Text = "Iptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(292, 116);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 24;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "label1";
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(67, 38);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(192, 20);
            this.txtKonu.TabIndex = 19;
            // 
            // dtpBasSaat
            // 
            this.dtpBasSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBasSaat.Location = new System.Drawing.Point(273, 12);
            this.dtpBasSaat.Name = "dtpBasSaat";
            this.dtpBasSaat.Size = new System.Drawing.Size(94, 20);
            this.dtpBasSaat.TabIndex = 16;
            // 
            // dtpBasTar
            // 
            this.dtpBasTar.Location = new System.Drawing.Point(67, 12);
            this.dtpBasTar.Name = "dtpBasTar";
            this.dtpBasTar.Size = new System.Drawing.Size(200, 20);
            this.dtpBasTar.TabIndex = 17;
            // 
            // rdbYapildi
            // 
            this.rdbYapildi.AutoSize = true;
            this.rdbYapildi.Location = new System.Drawing.Point(67, 64);
            this.rdbYapildi.Name = "rdbYapildi";
            this.rdbYapildi.Size = new System.Drawing.Size(56, 17);
            this.rdbYapildi.TabIndex = 25;
            this.rdbYapildi.TabStop = true;
            this.rdbYapildi.Text = "Yapıldı";
            this.rdbYapildi.UseVisualStyleBackColor = true;
            // 
            // rdbYapilacak
            // 
            this.rdbYapilacak.AutoSize = true;
            this.rdbYapilacak.Location = new System.Drawing.Point(158, 64);
            this.rdbYapilacak.Name = "rdbYapilacak";
            this.rdbYapilacak.Size = new System.Drawing.Size(72, 17);
            this.rdbYapilacak.TabIndex = 25;
            this.rdbYapilacak.TabStop = true;
            this.rdbYapilacak.Text = "Yapılacak";
            this.rdbYapilacak.UseVisualStyleBackColor = true;
            // 
            // GorevFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 161);
            this.Controls.Add(this.rdbYapilacak);
            this.Controls.Add(this.rdbYapildi);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.dtpBasSaat);
            this.Controls.Add(this.dtpBasTar);
            this.Name = "GorevFormu";
            this.Text = "GorevFormu";
            this.Load += new System.EventHandler(this.GorevFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.DateTimePicker dtpBasSaat;
        private System.Windows.Forms.DateTimePicker dtpBasTar;
        private System.Windows.Forms.RadioButton rdbYapildi;
        private System.Windows.Forms.RadioButton rdbYapilacak;
    }
}