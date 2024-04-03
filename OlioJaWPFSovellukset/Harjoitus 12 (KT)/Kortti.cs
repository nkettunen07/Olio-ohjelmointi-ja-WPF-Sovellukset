using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_12__KT_
{
    internal class Kortti
    {
        // Tehdään Kortti luokka jossa on numero (1-13) ja Tyyppi (Pata/Hertta/Ruutu/Risti)
        public int Numero { get; set; }
        public string Tyyppi { get; set; }

        public Kortti(int _Numero, string _Tyyppi)
        {
            // Tehdään Tyypit lista.
            string[] Tyypit = { "pata", "hertta", "ruutu", "risti" };

            // Katsotaan onko numero OK. (Ei olisi pakko tässä tehtävässä...)
            if (_Numero < 1 || _Numero > 13) throw new Exception("Numero ei ole väliltä 1-13");

            // Ja tyypin tarkistus (ei olisi pakko tässäkään...)
            // Array.Exists:illä katsotaan onko tyyppi Tyypit listassa. Jos ei, niin new Exception.
            if (Array.Exists(Tyypit, _tyyppi => _tyyppi == _Tyyppi) == false) throw new Exception($"Tyyppi on väärä. Nämä tyypit voit käyttää: {Tyypit.ToString()}");
            Numero = _Numero;
            Tyyppi = _Tyyppi;
        }
    }
}
