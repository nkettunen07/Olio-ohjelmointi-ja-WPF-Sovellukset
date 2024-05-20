using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_25
{
    internal class Joukkue
    {
        public string Nimi;
        public string Kotikaupunki;
        public List<Pelaaja> Pelaajat;

        public Joukkue(string nimi, string kotikaupunki, List<Pelaaja> pelaajat)
        {
            Nimi = nimi;
            Kotikaupunki = kotikaupunki;
            Pelaajat = pelaajat;
        }
        public void LisääPelaaja(Pelaaja pelaaja)
        {
            Pelaajat.Add(pelaaja);
        }
        public void PoistaPelaaja(Pelaaja pelaaja)
        {
            Pelaajat.Remove(pelaaja);
        }
    }
}
