using Vehicles;

class Program
{
    static void Main(string[] args)
    {
        Car myCar = new Car("Toyota", "Corolla", 2022, "Red");

        myCar.ShowInformation();

        Console.WriteLine("");

        myCar.Accelerate(50);

        myCar.Brake(20);

        Console.WriteLine("");

        myCar.ShowInformation();
    }
}