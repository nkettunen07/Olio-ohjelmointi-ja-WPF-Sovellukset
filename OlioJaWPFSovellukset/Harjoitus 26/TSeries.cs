using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_26
{
    internal class TSeries : Kanava
    {
        private readonly string kanava_id = "UCq-Fj5jknLsUf-MWSy4_brA";
        public int tilaajat = 0;
        public void Render()
        {
            try
            {
                string resp = Pyyntö(kanava_id); // tehdään pyyntö
                tilaajat = int.Parse(OtaJaFormatNumeroResponsesta(resp, true)); // asetetaan tilaajat muuttuja siihen numeroon
                MainWindow.tseries_id.Text = OtaJaFormatNumeroResponsesta(resp); // sama kuin ylhäällä mutta funktio tuo sen formatoituna
            }
            catch (Exception ex)
            {
                // odottaa vaan sitten...
            }
        }
    }
}
