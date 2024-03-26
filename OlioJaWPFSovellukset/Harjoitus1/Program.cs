// See https://aka.ms/new-console-template for more information
using Harjoitus1;


internal class Program
{
    private static void Main(string[] args)
    {
        // Tehdään auto
        Ajoneuvo Auto = new Ajoneuvo();
        Auto.Nimi = "Niauto";
        Auto.Renkaat = 5;
        Auto.Nopeus = 100;
        // Tulostetaan auton tiedot
        Auto.TulostaData();
    }
}