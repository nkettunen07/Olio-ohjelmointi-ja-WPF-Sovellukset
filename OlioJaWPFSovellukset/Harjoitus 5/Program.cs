using Harjoitus5;

internal class Program
{
    private static void Main(string[] args)
    {
        // Lasketaan numeroita...
        float Summa = Laskin.Summa(1, 2);
        float Erotus = Laskin.Erotus(1, 2);
        float Kerto = Laskin.Kertolasku(1, 2);
        float Jako = Laskin.Jako(1, 2);
        Console.WriteLine($"Summa: {Summa}");
        Console.WriteLine($"Erotus: {Erotus}");
        Console.WriteLine($"Kerto: {Kerto}");
        Console.WriteLine($"Jako: {Jako}");
    }
}