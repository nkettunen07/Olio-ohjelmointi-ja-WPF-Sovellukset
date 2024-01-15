using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4
{
    internal class Kappale
    {
        private string Nimi {  get; set; }
        private string Pituus { get; set; }
        public Kappale(string _Nimi, string _Pituus)
        {
            Nimi = _Nimi;
            Pituus = _Pituus;
        }
        public string ToString()
        {
            return $"--- Nimi: {Nimi} - ${Pituus}";
        }
    }
}
