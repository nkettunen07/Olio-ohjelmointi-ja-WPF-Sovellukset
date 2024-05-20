using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_25
{
    internal class Pelaaja
    {
        public string Etunimi;
        public string Sukunimi;
        public int PelaajaNro;
        [System.ComponentModel.Browsable(false)]
        public Joukkue Joukkue;

        public Pelaaja(string etunimi, string sukunimi, int pelaajaNro, Joukkue joukkue)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            PelaajaNro = pelaajaNro;
            Joukkue = joukkue;
        }
    }
}
