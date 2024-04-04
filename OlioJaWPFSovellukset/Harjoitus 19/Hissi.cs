using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_19
{
    internal class Hissi
    {
        private static int _kerros { get; set; }
        private int Kerros
        {
            get
            {
                return _kerros;
            }
            set
            {
                // value voi olla vain 1-6 väliltä
                if (value >= 1 && value <= 6)
                {
                    _kerros = value;
                    //Console.WriteLine($"Hissi on nyt kerroksessa {_kerros}");
                }
                else
                {
                    // koska olemme WPF sovelluksessa... Nämä console.writelinet ovat turhia.
                    //Console.WriteLine($"Antamasi kerros ei ole valitettavasti toimiva kerros. Anna kerros väliltä 1-6");
                }
            }
        }
        public void Asetakerros(int _krs)
        {
            Kerros = _krs; // koitetaan asettaa kerros antamaan numeroon
        }
        public int kerrokset() { return _kerros; } // Viimeisin hyväksytty kerros
    }
}
