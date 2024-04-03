using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_13__KT_
{
    internal class Pelaaja
    {
        public string Etunimi;
        public string Sukunimi;
        public int PelaajaNumero;

        public Pelaaja(string _Etunimi, string _Sukunimi, int _PelaajaNumero)
        {
            Etunimi = _Etunimi;
            Sukunimi = _Sukunimi;
            PelaajaNumero = _PelaajaNumero;
        }
    }
}
