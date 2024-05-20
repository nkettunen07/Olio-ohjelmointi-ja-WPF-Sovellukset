using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Harjoitus_26
{
    internal class MrBeast : Kanava
    {
        private readonly string kanava_id = "UCX6OQ3DkcsbYNE6H8uQQuVA"; // MIKÄ TÄMÄ ON? KAIKILLA KANAVILLA ON 1 TIETTY KANAVA IDENTIFIKAATIO STRINGI.
        public int tilaajat = 0;
        public void Render()
        {
            try
            {
                string resp = Pyyntö(kanava_id); // Tehdään pyyntö
                tilaajat = int.Parse(OtaJaFormatNumeroResponsesta(resp, true)); // asetetaan tilaajat muuttuja siihen numeroon
                MainWindow.mrbeast_id.Text = OtaJaFormatNumeroResponsesta(resp); // sama kuin ylhäällä mutta funktio tuo sen formatoituna
            } catch(Exception ex)
            {
                // odottaa vaan sitten...
            }
        }
    }
}
