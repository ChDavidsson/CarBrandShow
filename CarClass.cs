namespace CarBrandShow;

public class Car
    {

        // Klass Car med Brand, Model, Color.
    
        public string Brand;
        public string Model;
        public string Color;
    
        // ReadInfo() frågar användaren om bilen.

        public void ReadInfo()
        {
            Console.WriteLine("What brand is your car?");
            Brand = Console.ReadLine()!;
            Console.WriteLine("What model is your car?");
            Model = Console.ReadLine()!;
            Console.WriteLine("What color is your car?");
            Color = Console.ReadLine()!;
        }
    // ShowCar() skriver ut:

        public void ShowCar()
        {
            Console.WriteLine($"{Color} {Brand} {Model}");
        }
    }