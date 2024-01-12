using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus1
{
    internal class Ajoneuvo
    {
        public string Nimi { get; set; }
        public int Nopeus { get; set; }
        public int Renkaat { get; set; }
        public Ajoneuvo(string _Nimi, int _Nopeus, int _Renkaat)
        {
            Nimi = _Nimi;
            Nopeus = _Nopeus;
            Renkaat = _Renkaat;
        }

        public void TulostaData()
        {
            // Mun pää hajos :3
            Console.WriteLine(ToString());
        }
        public string ToString()
        {
            return Nimi + " " + Nopeus + "km/h " + Renkaat + " rengasta";
        }
    }
}
