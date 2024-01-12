using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2
{
    internal class Opiskelija
    {
        private string Nimi { get; set; }
        private string OpiskelijaID { get; set; }
        private int Opintopisteet { get; set; }

        public Opiskelija(string _Nimi, string _OpiskelijaID, int _Opintopisteet) { 
            Nimi = _Nimi;
            OpiskelijaID = _OpiskelijaID;
            Opintopisteet = _Opintopisteet;
        }
        public void TulostaData()
        {
            Console.WriteLine("nimi: " + Nimi + " OpiskelijaID: " + OpiskelijaID + " Opintopisteet: " + Opintopisteet);
        }
        public void MuokkaaOpintopisteitä(int i)
        {
            Opintopisteet = i;
        }
    }
}
