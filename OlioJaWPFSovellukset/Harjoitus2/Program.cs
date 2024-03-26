using Harjoitus2;

internal class Program
{
    private static void Main(string[] args)
    {
        // Tehdään opiskelija Matti
        Opiskelija Matti = new Opiskelija("Matti", "op_1", 10);
        Matti.TulostaData();
        Matti.MuokkaaOpintopisteitä(11);
        Matti.TulostaData();
    }
}