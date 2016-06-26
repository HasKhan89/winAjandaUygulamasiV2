namespace winAjandaUygulamasiV2
{
    partial class ToplatiFormu
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
            this.dtpBasTar = new System.Windows.Forms.DateTimePicker();
            this.dtpBasSaat = new System.Windows.Forms.DateTimePicker();
            this.dtpBitTar = new System.Windows.Forms.DateTimePicker();
            this.dtpBitSaat = new System.Windows.Forms.DateTimePicker();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTamam = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpBasTar
            // 
            this.dtpBasTar.Location = new System.Drawing.Point(118, 27);
            this.dtpBasTar.Name = "dtpBasTar";
            this.dtpBasTar.Size = new System.Drawing.Size(200, 20);
            this.dtpBasTar.TabIndex = 0;
            // 
            // dtpBasSaat
            // 
            this.dtpBasSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBasSaat.Location = new System.Drawing.Point(324, 27);
            this.dtpBasSaat.Name = "dtpBasSaat";
            this.dtpBasSaat.Size = new System.Drawing.Size(94, 20);
            this.dtpBasSaat.TabIndex = 0;
            // 
            // dtpBitTar
            // 
            this.dtpBitTar.Location = new System.Drawing.Point(118, 53);
            this.dtpBitTar.Name = "dtpBitTar";
            this.dtpBitTar.Size = new System.Drawing.Size(200, 20);
            this.dtpBitTar.TabIndex = 0;
            // 
            // dtpBitSaat
            // 
            this.dtpBitSaat.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpBitSaat.Location = new System.Drawing.Point(324, 53);
            this.dtpBitSaat.Name = "dtpBitSaat";
            this.dtpBitSaat.Size = new System.Drawing.Size(94, 20);
            this.dtpBitSaat.TabIndex = 0;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(118, 79);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(192, 20);
            this.txtKonu.TabIndex = 1;
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(118, 105);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(192, 20);
            this.txtMesaj.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "label1";
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(338, 168);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(75, 23);
            this.btnTamam.TabIndex = 3;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(257, 168);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "Iptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // ToplatiFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 203);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.dtpBitSaat);
            this.Controls.Add(this.dtpBasSaat);
            this.Controls.Add(this.dtpBitTar);
            this.Controls.Add(this.dtpBasTar);
            this.Name = "ToplatiFormu";
            this.Text = "ToplatiFormu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBasTar;
        private System.Windows.Forms.DateTimePicker dtpBasSaat;
        private System.Windows.Forms.DateTimePicker dtpBitTar;
        private System.Windows.Forms.DateTimePicker dtpBitSaat;
        private System.Windows.Forms.TextBox txtKonu;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTamam;
        private System.Windows.Forms.Button btnIptal;
    }
}