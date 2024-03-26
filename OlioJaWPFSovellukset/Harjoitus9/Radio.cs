using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus9
{
    internal class Radio
    {
        public bool Päällä { get; set; } = false; //true-false
        public int Äänenvoimakkuus { get; set; } = 0; // 0-9
        public double Taajuusvalinta { get; set; } = 88.0; // 88.0 - 107.9
        public void AsetaÄänenvoimakkuus(int _uusiVoimakkuus)
        {
            if(_uusiVoimakkuus >= 0 && _uusiVoimakkuus <= 9)
            {
                Äänenvoimakkuus = _uusiVoimakkuus;
                Console.WriteLine("Uusi äänen voimakkuus on "+ Äänenvoimakkuus);
            } else
            {
                Console.WriteLine("Äänenvoimakkuus voi vain olla 0-9 välillä.");
            }
        }
        public void LaitaPäällePois()
        {
            if (Päällä) Päällä = false;
            else Päällä = true;
            Console.WriteLine("Radio on nyt " + (Päällä == true ? "Päällä" : "Pois päältä"));
        }
        public void VaihdaKanava(double _uusiKanava)
        {
            if(_uusiKanava >= 88.0 && _uusiKanava <= 107.9)
            {
                Taajuusvalinta = _uusiKanava;
                Console.WriteLine("Kanava on nyt " + Taajuusvalinta);
            } else
            {
                Console.WriteLine("Valitettavasti radion taajuus voi vain olla välillä 88.0-107.9");
            }
        }
    }
}