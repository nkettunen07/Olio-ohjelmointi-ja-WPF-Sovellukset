using Harjoitus_11;
internal class Program
{
    private static void Main(string[] args)
    {
        // Tämä dictionary sisältää kaikki opiskelijat.
        Kokoelma opiskelijaKokoelma = new Kokoelma();
        Console.WriteLine("Hei. Pääset hallinoimaan opiskelijoita.");
        while (true)
        {
            Console.WriteLine("LISÄÄ lisätääksesi, POISTA poistaaksesi ja TULOSTA tulostaaksesi.");
            string Komento = Console.ReadLine(); // Komento voi olla LISÄÄ, POISTA tai TULOSTA
            if(Komento == "LISÄÄ")
            {
                opiskelijaKokoelma.Lisää();
            } else if(Komento == "POISTA")
            {
                // Kysytään opiskelijaID:tä
                Console.WriteLine("Anna opiskelijan OPISKELIJAID");
                string OpiskelijaID = Console.ReadLine();
                opiskelijaKokoelma.Poista(OpiskelijaID);
            } else if(Komento == "TULOSTA")
            {
                opiskelijaKokoelma.Tulosta();
            } else
            {
                Console.WriteLine("Komento ei löydetty.");
            }
        }
    }
}