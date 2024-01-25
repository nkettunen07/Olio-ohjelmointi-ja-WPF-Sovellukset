using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus8
{
    public abstract class Henkilö
    {
        public string? Nimi;
        public string? Työpaikka;
        public int Palkka; // kk


        public static int Pomoja = 0;
    }
    public class Työntekijä : Henkilö
    {
        public int ViikottaisetTunnit;
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
        public int bonus;
        public string auto;
        public Pomo(string nimi, string työpaikka, int palkka, int _bonus, string _auto)
        {
            if(Pomoja >= 1)
            {
                throw new Exception("Pomo on jo.");
            }
            Nimi = nimi;
            Työpaikka = työpaikka;
            Palkka = palkka;
            bonus = _bonus;
            auto = _auto;
            Pomoja += 1;
        }
    }
}
