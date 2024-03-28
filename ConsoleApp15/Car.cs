using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Car
    {
        public string Brend;
        public string Model;
        public string Year;
        public string FuelType;
        public string Color;

        public Car(string brend, string model, string year, string fuelType, string color)
        {
            this.Brend = brend;
            this.Model = model;
            this.Year = year;
            this.FuelType = fuelType;
            this.Color = color;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Brend-{Brend} Model-{Model} Year-{Year} FuelType-{FuelType} Color-{Color}");
        }
    }
}
