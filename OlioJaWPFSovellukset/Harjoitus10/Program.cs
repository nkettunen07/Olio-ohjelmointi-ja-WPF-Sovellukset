namespace Harjoitus10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Tehdään varis
            Varis Varis = new();
            Varis.Name = "test";
            Varis.WingSize = 10;
            Varis.Fly();
            Varis.MakeASound();
            
            // Tehdään lehmä
            Lehmä Lehmä = new();
            Lehmä.Name = "Lemhä";
            Lehmä.SwimSpeed= 100;
            Lehmä.Swim();
            Lehmä.MakeASound();
        }
    }
    internal class Varis : Animal, ICanFly
    {
        public int WingSize { get; set; }
        public virtual void Fly()
        {
            Console.WriteLine("Moi lennän" + WingSize+Name);
        }
    }
    internal class Lehmä : Animal, ICanSwim
    {
        public int SwimSpeed { get; set; }
        public virtual void Swim()
        {
            Console.WriteLine("Moi uin"+ SwimSpeed+Name);
        }
    }
}
