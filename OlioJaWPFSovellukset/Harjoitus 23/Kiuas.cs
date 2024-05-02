using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_23
{
    internal class Kiuas
    {
        private bool Päällä { get; set; }
        private int Lämpötila {  get; set;
        }
        private int Kosteus {  get; set; }
        public Kiuas(bool _Päällä, int _Lämpötila, int _Kosteus)
        {
            Päällä = _Päällä;
            if(_Lämpötila >= 0 && _Lämpötila <= 120) Lämpötila = _Lämpötila;
            if (_Kosteus>= 0 && _Kosteus<= 100) Kosteus = _Kosteus;
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
            if (_Lämpötila >= 0 && _Lämpötila <= 120) Lämpötila = _Lämpötila;
            if (_Kosteus >= 0 && _Kosteus <= 100) Kosteus = _Kosteus;
        }
        public void Tulosta()
        {
            Console.WriteLine($"Päällä {Päällä}, Lämpötila {Lämpötila}, Kosteus {Kosteus}");
        }
        public int getLämpötila()
        {
            return Lämpötila;
        }
        public int getKosteus()
        {
            return Kosteus;
        }
    }
}
