using Harjoitus_14;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Muistiinpano> muistiinpanot;
        try
        {
            // Katsotaan onko Muistiinpanoja tiedostossa
            // Tehdään binaari formatteri
            IFormatter formatter = new BinaryFormatter();
            // Luetaan tiedosto
            Stream readStream = new FileStream("Muistiinpanot.bin", FileMode.Open, FileAccess.Read, FileShare.None);
            // Laitetaan muistiinpano listaan tallennetut tiedot tiedostosta.
            muistiinpanot = (List<Muistiinpano>)formatter.Deserialize(readStream);
        } catch(Exception ex)
        {
            // Ei ole.. Tyhjä lista.
            muistiinpanot = new();
        }
        // TÄMÄ SIIS TOIMII VAIKKA RESTARTTAA!!!
        while(true)
        {
            // Kysytään mitä tehdä
            Console.WriteLine("Moi. Mitä haluat tehdä?");
            string Teko = Console.ReadLine();

            // Jos on uusi/UUSI/UuSi/uUsI niin kysytään tiedot:
            if (Teko.ToLower().StartsWith("uusi"))
            {
                Console.WriteLine("Anna muistiinpanon tiedot:");
                string Otsikko = Console.ReadLine();
                Muistiinpano muistiinpano = new(Otsikko); // Tehdään muistiinpano olio
                muistiinpanot.Add(muistiinpano); // lisätään se

                // Tallennetaan...
                Console.WriteLine("Tallennetaan...");
                // Kirjotetaan muistiinpanot-tiedosto...
                Stream writeStream = new FileStream("Muistiinpanot.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(writeStream, muistiinpanot);
                writeStream.Close();
                Console.WriteLine("Tallennettu.");
            }
            // Jos on tulos/TULOS.... niin tulostetaan kaikki muistiinpanot listassa.
            else if (Teko.ToLower().StartsWith("tulos"))
            {
                // Kaikki muistiinpanot listassa..
                foreach (Muistiinpano i in muistiinpanot)
                {
                    Console.WriteLine(i.Otsikko);
                }
            }
            // Jos on tyhj/TYHJ/TYHJENNÄ .... niin edelleen... niin tyhjennetään muistiinpanot.
            else if (Teko.ToLower().StartsWith("tyhj"))
            {
                // Nopea ja simppeli tyhjennys:
                muistiinpanot = new();
                Console.WriteLine("Tyhjennetään...");
                // Kirjotetaan/Päivitetään muistiinpanot-tiedosto...
                Stream writeStream = new FileStream("Muistiinpanot.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(writeStream, muistiinpanot);
                writeStream.Close();
                Console.WriteLine("Tyhjennetty.");
            } else
            {
                Console.WriteLine("Toimintoja ovat uusi, tulos ja tyhj(ennä)");
            }
        }

    }
}