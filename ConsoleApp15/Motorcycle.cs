using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Motorcycle
    {
        public string Brend;
        public string Model;
        public string Year;
        public int MaxSpeed;
        public bool HasSideCar;

        public Motorcycle(string brend, string model, string year, int maxSpeed, bool hasSidecar) 
        {
            Brend = brend;
            Model = model;
            Year = year;
            MaxSpeed = maxSpeed;
            HasSideCar = hasSidecar;
        }
    }
}
