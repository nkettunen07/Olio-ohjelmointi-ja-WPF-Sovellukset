using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus_11
{
    internal class Kokoelma
    {
        Dictionary<string, Opiskelija> opiskelijat = new();

        public void Poista(string OpiskelijaID)
        {
            // Katsotaan onko oikea OpiskelijaID
            if (opiskelijat.ContainsKey(OpiskelijaID) == false)
            {
                // Ei ollut, mennään takas alkuun...
                Console.WriteLine($"Opiskelija ID {OpiskelijaID} ei ole olemassa. Kirjoita TULOSTA niin näet kaikki opiskelijat.");
                return;
            }
            // Oli. Tallennetaan tiedot muistiin hetkeksi ennen poistoa
            Opiskelija opiskelija;
            opiskelijat.TryGetValue(OpiskelijaID, out opiskelija); // Otamme tiedot
            opiskelijat.Remove(OpiskelijaID); // Poistetaan dictionarysta
                                              // Ja nyt voimme sanoa että se on poistettu. Hienostelulla voimme näyttää KENET poistettiin.
                                              // Aina ei ole pakko...
            Console.WriteLine($"Opiskelija {opiskelija.Etunimi} {opiskelija.Sukunimi} ({OpiskelijaID}) on poistettu.");
        }
        public void Lisää()
        {
            // Kysytään opiskelijan tiedot;
            Console.WriteLine("Anna opiskelijan tiedot näin: ETUNIMI,SUKUNIMI,RYHMÄTUNNUS,OPISKELIJAID");
            try
            {
                // Jaetaan antamat tiedot pilkulla
                string[] Tiedot = Console.ReadLine().Split(",");
                string Etunimi = Tiedot[0];
                string Sukunimi = Tiedot[1];
                string Ryhmätunnus = Tiedot[2];
                string OpiskelijaID = Tiedot[3];
                // Annetaan jokaiselle valuelle nimi;

                // Katsotaan onko opiskelijaID jo olemassa
                if (opiskelijat.ContainsKey(OpiskelijaID))
                {
                    Console.WriteLine($"Opiskelija ID {OpiskelijaID} on JO olemassa.");
                    return; // Oli olemassa, ei jatketa enää, mennään alkuun.
                }
                // Lisätään opiskelija "opiskelijat" dictionaryyn.
                opiskelijat.Add(OpiskelijaID, new Opiskelija(Etunimi, Sukunimi, Ryhmätunnus, OpiskelijaID));
                Console.WriteLine($"Opiskelija {Etunimi} {Sukunimi} on lisätty.");
            }
            catch (Exception ex)
            {
                //try-catch jotta sovellus ei kaadu jos käyttäjä kirjoittaa opiskelija tiedot VÄÄRIN.
                Console.WriteLine("Taisit kirjoittaa opiskelijan tiedot VÄÄRIN. Yritä uudelleen.");
            }
        }
        public void Tulosta()
        {
            // Tulostetaan jokaisen opiskelijan tiedot erilliselle riville.
            foreach (Opiskelija oppilas in opiskelijat.Values)
            {
                Console.WriteLine($"{oppilas.OpiskelijaID}: {oppilas.Etunimi} {oppilas.Sukunimi} {oppilas.Ryhmätunnus}");
            }
            if (opiskelijat.Values.Count == 0) Console.WriteLine("(Tyhjä)");
        }
    }
}
