using Harjoitus3__KT_;

internal class Program
{
    private static void Main(string[] args)
    {
        Kiuas Harvia = new Kiuas(false, 0, 0);
        Harvia.Tulosta();
        //Asetetaan kiuas päälle
        Harvia.Laitapäälle();
        //Asetetaan lämpötila ja kosteus
        Harvia.Lämpötila_Kosteus(100, 10);
        Harvia.Tulosta();

        //Laitetaan pois päältä
        Harvia.Laitapois();
        Harvia.Lämpötila_Kosteus(0, 0);
        Harvia.Tulosta();
        // Noin!
    }
}

