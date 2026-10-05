namespace CarBrandShow;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car();
        car1.ReadInfo();

        Car car2 = new Car();
        car2.ReadInfo();

        Console.WriteLine("The cars entered are:");
        car1.ShowCar();
        car2.ShowCar();

    }
}
