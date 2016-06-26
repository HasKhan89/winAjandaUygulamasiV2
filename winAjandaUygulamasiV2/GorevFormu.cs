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
    public partial class GorevFormu : Form
    {
        public GorevFormu()
        {
            InitializeComponent();
        }

        public Gorev GorevNesnesi { get; set; }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            DateTime basTarSaat =
                new DateTime(
                    dtpBasTar.Value.Year, dtpBasTar.Value.Month, dtpBasTar.Value.Day,
                    dtpBasSaat.Value.Hour, dtpBasSaat.Value.Minute, dtpBasSaat.Value.Second);

            GorevNesnesi = new Gorev();
            GorevNesnesi.GorevTar = basTarSaat;
            GorevNesnesi.Konu = txtKonu.Text;
            GorevNesnesi.YapildiMi = rdbYapildi.Checked;

            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GorevFormu_Load(object sender, EventArgs e)
        {
            rdbYapilacak.Checked = true;
        }
    }
}
