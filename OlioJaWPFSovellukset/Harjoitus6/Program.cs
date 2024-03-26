using Harjoitus6;

internal class Program
{
    private static void Main(string[] args)
    {
        // Tehdään koira
        Koira munkoira = new();
        Console.WriteLine($"Eläimiä nyt pt 1: {Eläin.Olemassa}");
        // Tehdään kissa
        Kissa munkissa = new();
        Console.WriteLine($"Eläimiä nyt pt 2: {Eläin.Olemassa}");
    }
}

// WAOW....!!!!