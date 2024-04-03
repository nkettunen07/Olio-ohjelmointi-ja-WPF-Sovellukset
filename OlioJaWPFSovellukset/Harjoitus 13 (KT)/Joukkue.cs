using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_13__KT_
{
    internal class Joukkue
    {
        public string Nimi;
        public string Kotikaupunki;
        private Dictionary<int, Pelaaja> Pelaajat = new();
        public Joukkue(string _Nimi, string _Kotikaupunki)
        {
            Nimi = _Nimi;
            Kotikaupunki = _Kotikaupunki;
        }
        public Pelaaja HaePelaaja(int _PelaajaNumero)
        {
            Pelaaja Tiedot;
            // out Pelaaja value vaaditan että TryGetValue toimisi. Sitä ei kuitenkaan käytetä.
            if (Pelaajat.TryGetValue(_PelaajaNumero, out Pelaaja value) == true) new Exception("Pelaajaa ei löytynyt.");
            Pelaajat.TryGetValue(_PelaajaNumero, out Tiedot);
            return Tiedot; // Tyhmin work-around mutta se TOIMII..! jotenkin.
        }
        public void LisääPelaaja(Pelaaja PelaajaTiedot)
        {
            // out Pelaaja value vaaditan että TryGetValue toimisi. Sitä ei kuitenkaan käytetä.
            if (Pelaajat.TryGetValue(PelaajaTiedot.PelaajaNumero, out Pelaaja value) == true) new Exception("PelaajaNRO on jo pelaajissa.");
            else Pelaajat.Add(PelaajaTiedot.PelaajaNumero, PelaajaTiedot);
        }
        public void PoistaPelaaja(int _PelaajaNumero)
        {
            // out Pelaaja value vaaditan että TryGetValue toimisi. Sitä ei kuitenkaan käytetä.
            if (Pelaajat.TryGetValue(_PelaajaNumero, out Pelaaja value) == false) new Exception("PelaajaNRO ei löytynyt.");
            else Pelaajat.Remove(_PelaajaNumero);
        }
        public List<Pelaaja> HaePelaajat()
        {
            return Pelaajat.Values.ToList(); // ??? Ok
        }
    }
}
