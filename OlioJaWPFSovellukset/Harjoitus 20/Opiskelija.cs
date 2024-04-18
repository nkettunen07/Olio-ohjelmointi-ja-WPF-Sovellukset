using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_20
{
    [Serializable]
    internal class Opiskelija
    {
        // Tämä on Opiskelija luokka. Sisältää tiedot opiskelijasta ja ovat PUBLIC koska sovelluksemme käyttää niitä.
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string OpiskelijaID { get; set; }
        public string Sähköposti { get; set; }
        public string Puhelinnumero { get; set; }

        public Opiskelija(string _Etunimi, string _Sukunimi, string _OpiskelijaID, string _Sähköposti, string _Puhelinnumero)
        {
            Etunimi = _Etunimi;
            Sukunimi = _Sukunimi;
            OpiskelijaID = _OpiskelijaID;
            Sähköposti = _Sähköposti;
            Puhelinnumero = _Puhelinnumero;
        }
    }
}
