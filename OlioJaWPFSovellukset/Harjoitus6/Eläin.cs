using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6
{
    public class Eläin
    {
        public static int Olemassa { get; set; } = 0;
        public virtual string? Tyyppi {  get; set; }
        public virtual void OlemassaOlevat()
        {
            Console.WriteLine($"Olemassa olevia eläimiä on {Olemassa}");
        }

    }
    public class Koira : Eläin
    {
        //public override string? Tyyppi { get; set; } // joo oon tyhmä.
        public Koira()
        {
            Console.WriteLine("Tehtiin koira");
            Olemassa++;
            Tyyppi = "Koira";
        }
    }
    public class Kissa : Eläin
    {
        public Kissa()
        {
            Console.WriteLine("Tehtiin kissa");
            Olemassa++;
            Tyyppi = "Kissa";
        }
    }

}
