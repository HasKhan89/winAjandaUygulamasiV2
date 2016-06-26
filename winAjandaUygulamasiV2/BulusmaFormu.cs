using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winAjandaUygulamasiV2
{
    public partial class BulusmaFormu : Form
    {
        public BulusmaFormu()
        {
            InitializeComponent();
        }

        public Bulusma BulusmaNesnesi { get; set; }
        public bool Durum { get; set; } = true;  // true : yeni eklemedir. false : düzenlemedir.

        private void btnTamam_Click(object sender, EventArgs e)
        {
            DateTime basTarSaat =
                new DateTime(
                    dtpBasTar.Value.Year, dtpBasTar.Value.Month, dtpBasTar.Value.Day,
                    dtpBasSaat.Value.Hour, dtpBasSaat.Value.Minute, dtpBasSaat.Value.Second);

            BulusmaNesnesi = new Bulusma();
            BulusmaNesnesi.BulusmaTar = basTarSaat;
            BulusmaNesnesi.Not = txtNot.Text;
            BulusmaNesnesi.Katilimcilar = txtKatilimci.Text;

            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            DateTime basTarSaat =
                new DateTime(
                    dtpBasTar.Value.Year, dtpBasTar.Value.Month, dtpBasTar.Value.Day,
                    dtpBasSaat.Value.Hour, dtpBasSaat.Value.Minute, dtpBasSaat.Value.Second);

            BulusmaNesnesi.BulusmaTar = basTarSaat;
            BulusmaNesnesi.Not = txtNot.Text;
            BulusmaNesnesi.Katilimcilar = txtKatilimci.Text;

            this.Close();
        }

        private void BulusmaFormu_Load(object sender, EventArgs e)
        {
            if(Durum == true)
            {
                btnTamam.Visible = true;
                btnDuzenle.Visible = false;
            }
            else
            {
                btnTamam.Visible = false;
                btnDuzenle.Visible = true;

                dtpBasTar.Value = BulusmaNesnesi.BulusmaTar;
                dtpBasSaat.Value = BulusmaNesnesi.BulusmaTar;
                txtNot.Text = BulusmaNesnesi.Not;
                txtKatilimci.Text = BulusmaNesnesi.Katilimcilar;
            }
        }
    }
}
