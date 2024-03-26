using Harjoitus8;

internal class Program
{
    private static void Main(string[] args)
    {
        // Tehdään työntekijöitä...!!!!
        Henkilö Työntekijä1 = new Työntekijä("N", "C", 10, 6);
        Console.WriteLine(Työntekijä1);
        Henkilö Työntekijä2 = new Työntekijä("H", "C", 10, 6);
        Console.WriteLine(Työntekijä2);
        Henkilö Työntekijä3 = new Työntekijä("G", "C", 10, 6);
        Console.WriteLine(Työntekijä3);
        Henkilö Työntekijä4 = new Työntekijä("F", "C", 10, 6);
        Console.WriteLine(Työntekijä4);
        Henkilö Työntekijä5 = new Työntekijä("E", "C", 10, 6);
        Console.WriteLine(Työntekijä5);
        Henkilö Työntekijä6 = new Työntekijä("D", "C", 10, 6);
        Console.WriteLine(Työntekijä6);
        Henkilö Työntekijä7 = new Työntekijä("C", "C", 10, 6);
        Console.WriteLine(Työntekijä7);
        Henkilö Työntekijä8 = new Työntekijä("A", "C", 10, 6);
        Console.WriteLine(Työntekijä8);

        // Tehdään pomo!
        Henkilö Pomo = new Pomo("B", "C", 20, 300, "yutong"); //
        Console.WriteLine(Pomo);
        // Tehdään toinen pomo!
        try
        {
            Console.WriteLine("Tehdään toinen pomo.");
            Henkilö Pomo2 = new Pomo("P", "C", 10, 200, "volov");
            Console.WriteLine(Pomo2);
        }
        catch (Exception e)
        {
            // Ei toiminut!
            Console.WriteLine(e.Message);
        }
    }
}