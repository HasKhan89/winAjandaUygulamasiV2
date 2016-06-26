using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAjandaUygulamasiV2
{
    public class Toplanti
    {
        public DateTime BaslangicTar { get; set; }
        public DateTime BitisTar { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }

        public override string ToString()
        {
            return "(Toplantı) " + Konu;
        }
    }
}
