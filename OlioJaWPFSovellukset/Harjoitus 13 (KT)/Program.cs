using Harjoitus_13__KT_;

internal class Program
{
    private static void Main(string[] args)
    {
        // Tehdään joukkue 1
        Joukkue Joukkue1 = new("Jk1", "Kk1");

        // Tehdään 2 pelaajaa. Pelaaja1 käytetään monta kertaa.
        Pelaaja Pelaaja1 = new("Pl1", "Sk1", 1);
        Pelaaja Pelaaja2 = new("Pl2", "Sk2", 2);
        // Lisätään Pelaaja1 Joukkue1 Pelaajiin.
        Joukkue1.LisääPelaaja(Pelaaja1);

        // Etitään Pelaaja1
        Console.WriteLine(Joukkue1.HaePelaaja(Pelaaja1.PelaajaNumero).Etunimi);
        
        // Poistetaan Pelaaja1
        Joukkue1.PoistaPelaaja(Pelaaja1.PelaajaNumero);
        // Etsitään Pelaaja1 taas. (ei löydy)
        Console.WriteLine(Joukkue1.HaePelaaja(Pelaaja1.PelaajaNumero)?.Etunimi??"Pelaajaa ei löytynyt.");

        // Lisätään Pelaaja1,Pelaaja1 (ei toimi, duplicate) ja Pelaaja2 joukkue1 pelaajiin
        Joukkue1.LisääPelaaja(Pelaaja1);
        Joukkue1.LisääPelaaja(Pelaaja1);
        Joukkue1.LisääPelaaja(Pelaaja2);

        // Tulostetaan pelaajat.
        Console.WriteLine($"Joukkueen {Joukkue1.Nimi} ({Joukkue1.Kotikaupunki}) pelaajat:");
        foreach(Pelaaja i in Joukkue1.HaePelaajat())
        {
            Console.WriteLine($"{i.Etunimi} {i.Sukunimi}: {i.PelaajaNumero}");
        }
    }
}