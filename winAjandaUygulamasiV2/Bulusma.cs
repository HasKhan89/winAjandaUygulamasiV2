using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAjandaUygulamasiV2
{
    public class Bulusma
    {
        public DateTime BulusmaTar { get; set; }
        public string Not { get; set; }
        public string Katilimcilar { get; set; }

        public override string ToString()
        {
            return "(Buluşma) " + BulusmaTar.ToString();
        }
    }
}
