using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    public class Car
    {
        private string brand;
        private string model;
        private int year;
        private string color;
        private int speed;

        public Car(string brand, string model, int year, string color)
        {
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.color = color;
            this.speed = 0;
        }

        public void Accelerate(int increment)
        {
            this.speed += increment;
            Console.WriteLine("The car accelerated to " + this.speed + " km/h");
        }

        public void Brake(int decrement)
        {
            this.speed -= decrement;
            if (this.speed < 0)
                this.speed = 0;
            Console.WriteLine("The car slowed down to " + this.speed + " km/h");
        }

        public void ShowInformation()
        {
            Console.WriteLine("Brand: " + this.brand);
            Console.WriteLine("Model: " + this.model);
            Console.WriteLine("Year: " + this.year);
            Console.WriteLine("Color: " + this.color);
            Console.WriteLine("Current Speed: " + this.speed + " km/h");
        }
    }
}
