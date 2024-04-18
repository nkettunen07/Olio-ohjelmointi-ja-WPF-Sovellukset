using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Harjoitus_20
{
    [Serializable]
    internal class Kokoelma
    {
        private Dictionary<string, Opiskelija> opiskelijat = new Dictionary<string, Opiskelija>();
        public bool Hae(string OpiskelijaID) // extra mut niih
        {
            return opiskelijat.TryGetValue(OpiskelijaID, out Opiskelija _); // _ koska ei tarvita. vaan otetaan true/false valuet
        }
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
        // nyt me tehdään niin mahtavalla tavalla että public void tulee jäämään.
        public void Lisää(string Etunimi, string Sukunimi, string OpiskelijaID, string Sähköposti, string Puhelinnumero)
        {
            try
            {
                
                // Katsotaan onko opiskelijaID jo olemassa
                if (opiskelijat.ContainsKey(OpiskelijaID))
                {
                    Console.WriteLine($"Opiskelija ID {OpiskelijaID} on JO olemassa.");
                    return; // Oli olemassa, ei jatketa enää, mennään alkuun.
                }
                // Lisätään opiskelija "opiskelijat" dictionaryyn.
                opiskelijat.Add(OpiskelijaID, new Opiskelija(Etunimi, Sukunimi, OpiskelijaID, Sähköposti, Puhelinnumero));
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
                Console.WriteLine($"{oppilas.OpiskelijaID}: {oppilas.Etunimi} {oppilas.Sukunimi} {oppilas.Sähköposti} {oppilas.Puhelinnumero}");
            }
            if (opiskelijat.Values.Count == 0) Console.WriteLine("(Tyhjä)");
        }
        public Dictionary<string, Opiskelija> Kaikki()
        {
            return opiskelijat;
        }
        public void Tallenna()
        {
            // Kirjotetaan/Päivitetään opiskelijat-tiedosto...
            Stream writeStream = new FileStream("Opiskelijat.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            formatter.Serialize(writeStream, opiskelijat);
            writeStream.Close();
        }
        public void Lue(Action TyhmäFunction) // Action koska kun on luettu, niin voimme renderöidä
        {
            try
            {
                // Katsotaan onko Opiskelijoita tiedostossa
                // Tehdään binaari formatteri
                IFormatter formatter = new BinaryFormatter();
                // Luetaan tiedosto
                Stream readStream = new FileStream("Opiskelijat.bin", FileMode.Open, FileAccess.Read, FileShare.None);
                // Laitetaan opiskelijat dictionaryyn tallennetut tiedot tiedostosta.
                opiskelijat = (Dictionary<string, Opiskelija>)formatter.Deserialize(readStream);
                readStream.Close();
                TyhmäFunction(); // yleensä on this.RenderoiSP();

                // Ilman tätä workaroundii tää ei toiminu miten halusin (järjestyksessä) koska se vaan veti molemmat heti samaan aikaan.
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                // Ei ole.. Tyhjä dictionary.
                opiskelijat = new Dictionary<string, Opiskelija>();
            }
        }
    }
}
