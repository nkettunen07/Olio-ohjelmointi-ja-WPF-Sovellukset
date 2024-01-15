using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4
{
    internal class Albumi
    {
        private string Artisti {  get; set; }
        private string Nimi { get; set; }
        private string Genre { get; set; }
        private string Hinta { get; set; }
        private List<Kappale> Kappaleet { get; set; }

        public Albumi(string _Artisti, string _Nimi, string _Genre, string _Hinta, List<Kappale> _Kappaleet)
        {
            Artisti = _Artisti;
            Nimi = _Nimi;
            Genre = _Genre;
            Hinta = _Hinta;
            Kappaleet = _Kappaleet;
        }

        public void LisääKappale(string _Nimi, string _Pituus)
        {
            Kappaleet.Add(new Kappale(_Nimi, _Pituus));
        }
        public void Tulosta()
        {
            Console.WriteLine("Albumi:");
            Console.WriteLine(" -Artisti: " + Artisti);
            Console.WriteLine(" -Nimi: " + Nimi);
            Console.WriteLine(" -Genre: " + Genre);
            Console.WriteLine(" -Hinta: " + Hinta);
            Console.WriteLine("Songs:");
            foreach (Kappale i in Kappaleet)
            {
                Console.WriteLine(i.ToString());
            }
        }

    }
}
