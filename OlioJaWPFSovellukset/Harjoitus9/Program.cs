using Harjoitus9;

internal class Program
{
    private static void Main(string[] args)
    {
        // Tehdään kanavia
        Kanava SuomiPop = new("SuomiPop", 95.9);
        Kanava RadioRock = new("Radio Rock", 88.3);
        Kanava YleSuomi = new("Yle Suomi", 92.6);
        Kanava RadioPooki = new("Radio Pooki", 106.0);
        Radio radio = new();
        radio.LaitaPäällePois();
        radio.AsetaÄänenvoimakkuus(8);
        radio.VaihdaKanava(92.6);
        // katotaan kanava onko oikein
        if (radio.Taajuusvalinta == YleSuomi.Taajuus) Console.WriteLine("Nyt soi " + YleSuomi.Nimi);
        // Ei oikein selitettävää....
        radio.LaitaPäällePois();
        radio.LaitaPäällePois();
        radio.AsetaÄänenvoimakkuus(10);
        radio.VaihdaKanava(10);
    }
}