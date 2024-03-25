using Harjoitus6;

internal class Program
{
    private static void Main(string[] args)
    {
        Koira munkoira = new();
        Console.WriteLine($"Eläimiä ny pt 1: {Eläin.Olemassa}");
        Kissa munkissa = new();
        Console.WriteLine($"Eläimiä ny pt 2: {Eläin.Olemassa}");
    }
}

// WAOW....!!!!