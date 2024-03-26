using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus9
{
    internal class Kanava
    {
        public string? Nimi { get; set; }
        public double Taajuus { get; set; } //88.0-107.9
        public Kanava(string _nimi, double _taajuus)
        {
            if(_taajuus >= 88.0 && _taajuus <= 107.9)
            {
                Nimi = _nimi;
                Taajuus = _taajuus;
            } else
            {
                new Exception("Vihaisuuteni takia Voit vain laittaa taajuudeksi 88.0-107.9 Eikä "+_taajuus);
            }
        }
    }
}
