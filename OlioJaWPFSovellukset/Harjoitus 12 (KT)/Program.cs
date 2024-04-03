using Harjoitus_12__KT_;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Kortti> Kortit = new(); // Lista sisältää kortit.
        string[] Tyypit = { "pata", "hertta", "ruutu", "risti" };
        foreach (string tyyppi in Tyypit) // ^
        {
            for (int i = 1; i < 14; i++) // Tehdään kortit jokaiselle tyypille (maalle) 1-13 väliltä
            {
                Kortit.Add(new Kortti(i, tyyppi)); // Lisätään listaan kortti.
                Console.WriteLine($"{Kortit.Count}. kortti on {tyyppi} - {i}");
            }
        }
        List<Kortti> Sekoitettu = Shuffle(Kortit); // Shuffle (alempana) sekoittaa Kortit-listan
        Console.WriteLine($"{Sekoitettu.Count} korttia on SEKOITETTU.");
        int _Kierros = 0; // Kierrokset
        foreach (Kortti SekKortti in Sekoitettu) // Menemme sekoitetun korttipakan läpi
        {
            _Kierros++; // Lisätään kierroksiin.
            Console.WriteLine($"{_Kierros}. kortti on {SekKortti.Tyyppi} - {SekKortti.Numero}");
        }
    }
    static List<Kortti> Shuffle(List<Kortti> Kortit)
    {
        // Sekoitamme kortit.
        // Ensimmäisenä tehdään Random numero "generaattori"
        Random rng = new Random();
        // https://stackoverflow.com/questions/273313/randomize-a-listt ^^

        // Returnataan sekoitettu lista. Sekoitamme se OrderBy metodilla joka ottaa Random numeron rng.Next():llä joka antaa jokaiselle listan osalle random numeron
        // Jolla sitten voidaan sekoittaaa se.
        // Lopuksi muutetaan se takaisin listaksi.
        return Kortit.OrderBy(_ => rng.Next()).ToList();
    }
}