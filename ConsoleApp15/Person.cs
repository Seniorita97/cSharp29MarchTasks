using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Person
    {
        public string Name;
        public string Surame;
        public byte Age;
        public bool IsAdult;

        public Person(string name, string surname, byte age)
        {
            this.Name = name;
            this.Surame = surname;
            this.Age = age;
            if (Age >= 18)
            {
                IsAdult = true;
            }
            else
            {
                IsAdult = false;
            }
        }

    }
}
