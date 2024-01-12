using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3__KT_
{
    internal class Kiuas
    {
        private bool Päällä { get; set; }
        private int Lämpötila {  get; set; }
        private int Kosteus {  get; set; }
        public Kiuas(bool _Päällä, int _Lämpötila, int _Kosteus)
        {
            Päällä = _Päällä;
            Lämpötila = _Lämpötila;
            Kosteus = _Kosteus;
        }

        public void Laitapäälle()
        {
            Päällä = true;
        }
        public void Laitapois()
        {
            Päällä = false;
        }
        public void Lämpötila_Kosteus(int _Lämpötila, int _Kosteus)
        {
            Lämpötila = _Lämpötila;
            Kosteus = _Kosteus;
        }
        public void Tulosta()
        {
            Console.WriteLine($"Päällä {Päällä}, Lämpötila {Lämpötila}, Kosteus {Kosteus}");
        }
    }
}
