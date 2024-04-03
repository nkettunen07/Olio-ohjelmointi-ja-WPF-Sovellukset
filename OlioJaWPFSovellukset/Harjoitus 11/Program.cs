using Harjoitus_11;
internal class Program
{
    private static void Main(string[] args)
    {
        // Tämä dictionary sisältää kaikki opiskelijat.
        Dictionary<string, Opiskelija> opiskelijat = new();
        Console.WriteLine("Hei. Pääset hallinoimaan opiskelijoita.");
        while (true)
        {
            Console.WriteLine("LISÄÄ lisätääksesi, POISTA poistaaksesi ja TULOSTA tulostaaksesi.");
            string Komento = Console.ReadLine(); // Komento voi olla LISÄÄ, POISTA tai TULOSTA
            if(Komento == "LISÄÄ")
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
                        continue; // Oli olemassa, ei jatketa enää, mennään alkuun.
                    }
                    // Lisätään opiskelija "opiskelijat" dictionaryyn.
                    opiskelijat.Add(OpiskelijaID, new Opiskelija(Etunimi, Sukunimi, Ryhmätunnus, OpiskelijaID));
                    Console.WriteLine($"Opiskelija {Etunimi} {Sukunimi} on lisätty.");
                } catch(Exception ex)
                {
                    //try-catch jotta sovellus ei kaadu jos käyttäjä kirjoittaa opiskelija tiedot VÄÄRIN.
                    Console.WriteLine("Taisit kirjoittaa opiskelijan tiedot VÄÄRIN. Yritä uudelleen.");
                }
            } else if(Komento == "POISTA")
            {
                // Kysytään opiskelijaID:tä
                Console.WriteLine("Anna opiskelijan OPISKELIJAID");
                string OpiskelijaID = Console.ReadLine();

                // Katsotaan onko oikea OpiskelijaID
                if (opiskelijat.ContainsKey(OpiskelijaID) == false)
                {
                    // Ei ollut, mennään takas alkuun...
                    Console.WriteLine($"Opiskelija ID {OpiskelijaID} ei ole olemassa. Kirjoita TULOSTA niin näet kaikki opiskelijat.");
                    continue;
                }
                // Oli. Tallennetaan tiedot muistiin hetkeksi ennen poistoa
                Opiskelija opiskelija;
                opiskelijat.TryGetValue(OpiskelijaID, out opiskelija); // Otamme tiedot
                opiskelijat.Remove(OpiskelijaID); // Poistetaan dictionarysta
                // Ja nyt voimme sanoa että se on poistettu. Hienostelulla voimme näyttää KENET poistettiin.
                // Aina ei ole pakko...
                Console.WriteLine($"Opiskelija {opiskelija.Etunimi} {opiskelija.Sukunimi} ({OpiskelijaID}) on poistettu.");
            } else if(Komento == "TULOSTA")
            {
                // Tulostetaan jokaisen opiskelijan tiedot erilliselle riville.
                foreach(Opiskelija oppilas in opiskelijat.Values)
                {
                    Console.WriteLine($"{oppilas.OpiskelijaID}: {oppilas.Etunimi} {oppilas.Sukunimi} {oppilas.Ryhmätunnus}");
                }
                if (opiskelijat.Values.Count == 0) Console.WriteLine("(Tyhjä)");
            } else
            {
                Console.WriteLine("Komento ei löydetty.");
            }
        }
    }
}