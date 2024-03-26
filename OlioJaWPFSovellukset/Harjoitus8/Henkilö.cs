using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8
{
    public abstract class Henkilö
    {
        public string? Nimi { get; set; }
        public string? Työpaikka { get; set; }
        public int Palkka { get; set; } // kk


        public static int Pomoja { get; set; } = 0;
    }
    public class Työntekijä : Henkilö
    {
        public int ViikottaisetTunnit { get; set; }
        public Työntekijä(string nimi, string työpaikka, int palkka, int _vt)
        {
            Nimi = nimi;
            Työpaikka = työpaikka;
            Palkka = palkka;
            ViikottaisetTunnit = _vt;
        }

    }
    public class Pomo : Henkilö
    {
        public int Bonus { get; set; }
        public string Auto { get; set; }
        public Pomo(string nimi, string työpaikka, int palkka, int _bonus, string _auto)
        {
            if(Pomoja >= 1)
            {
                throw new Exception("Pomo on jo.");
            }
            Nimi = nimi;
            Työpaikka = työpaikka;
            Palkka = palkka;
            Bonus = _bonus;
            Auto = _auto;
            Pomoja += 1;
        }
    }
}
