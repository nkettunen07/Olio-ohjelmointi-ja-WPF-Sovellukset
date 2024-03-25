using Harjoitus7;

internal class Program
{
    private static void Main(string[] args)
    {
        Hissi elevaattori = new();
        while (true)
        {
            Console.WriteLine($"Hissin kerros on {elevaattori.kerrokset()}. Anna kerros mihin haluat hissin.");
            int outer = 0;
            int.TryParse(Console.ReadLine(), out outer);
            elevaattori.Asetakerros(outer);
        }
    }
}