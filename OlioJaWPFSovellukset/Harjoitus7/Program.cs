using Harjoitus7;

Hissi elevaattori = new();
while (true)
{
    Console.WriteLine($"Hissin kerros on {elevaattori.kerrokset()}. Anna kerros mihin haluat hissin.");
    int outer = 0;
    int.TryParse(Console.ReadLine(), out outer);
    elevaattori.Asetakerros(outer);
}