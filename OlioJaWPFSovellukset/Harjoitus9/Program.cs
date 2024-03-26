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
        Radio radio = new(); // Tehdään raido
        radio.LaitaPäällePois();
        radio.AsetaÄänenvoimakkuus(8);
        radio.VaihdaKanava(92.6);
        // katotaan kanava onko oikein
        if (radio.Taajuusvalinta == YleSuomi.Taajuus) Console.WriteLine("Nyt soi " + YleSuomi.Nimi);
        else if (radio.Taajuusvalinta == SuomiPop.Taajuus) Console.WriteLine("Nyt soi " + SuomiPop.Nimi);
        else if (radio.Taajuusvalinta == RadioRock.Taajuus) Console.WriteLine("Nyt soi " + RadioRock.Nimi);
        else if (radio.Taajuusvalinta == RadioPooki.Taajuus) Console.WriteLine("Nyt soi " + RadioPooki.Nimi);
        // Ei oikein selitettävää....
        radio.LaitaPäällePois();
        radio.LaitaPäällePois();
        radio.AsetaÄänenvoimakkuus(10);
        radio.VaihdaKanava(10);
    }
}