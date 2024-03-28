using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Car2
    {
        public string Brend;
        public string Model;
        public string Year;
        public int MaxSpeed;
        public byte NumSeats;

        public Car2(string brend, string model, string year, int maxSpeed, byte numSeats)
        {
            Brend = brend;
            Model = model;
            Year = year;
            MaxSpeed = maxSpeed;
            NumSeats = numSeats;
        }
    }
}
