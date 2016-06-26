using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winAjandaUygulamasiV2
{
    public class Gorev
    {
        public DateTime GorevTar { get; set; }
        public string Konu { get; set; }
        public bool YapildiMi { get; set; }

        public override string ToString()
        {
            string yapilmaDurumu = " (Yapılmadı)";
            
            if(YapildiMi == true)
            {
                yapilmaDurumu = " (Yapıldı)";
            }

            return "(Görev) " + Konu + yapilmaDurumu;
        }
    }


}
