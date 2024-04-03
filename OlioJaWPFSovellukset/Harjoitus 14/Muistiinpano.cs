using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_14
{
    [Serializable]
    internal class Muistiinpano
    {
        // Muistiinpanot olio jossa on vain "otsikko" (se muistiinpano)
        public string Otsikko {  get; set; }

        public Muistiinpano(string _Otsikko)
        {
            Otsikko = _Otsikko;
        } 

    }
}
