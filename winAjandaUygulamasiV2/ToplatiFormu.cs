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
    public partial class ToplatiFormu : Form
    {
        public ToplatiFormu()
        {
            InitializeComponent();
        }

        public Toplanti ToplantiNesnesi { get; set; }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            DateTime basTarSaat =
                new DateTime(
                    dtpBasTar.Value.Year, dtpBasTar.Value.Month, dtpBasTar.Value.Day,
                    dtpBasSaat.Value.Hour, dtpBasSaat.Value.Minute, dtpBasSaat.Value.Second);

            DateTime bitTarSaat =
               new DateTime(
                   dtpBitTar.Value.Year, dtpBitTar.Value.Month, dtpBitTar.Value.Day,
                   dtpBitSaat.Value.Hour, dtpBitSaat.Value.Minute, dtpBitSaat.Value.Second);

            ToplantiNesnesi = new Toplanti();
            ToplantiNesnesi.BaslangicTar = basTarSaat;
            ToplantiNesnesi.BitisTar = bitTarSaat;
            ToplantiNesnesi.Konu = txtKonu.Text;
            ToplantiNesnesi.Mesaj = txtMesaj.Text;

            this.Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
