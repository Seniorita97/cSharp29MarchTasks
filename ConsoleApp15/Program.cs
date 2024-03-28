using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------Task1-----------------------------------------

            //Person person1 = new Person("Ali", "Valiyev", 27);
            //Person person2 = new Person("Ali", "Valiyev", 17);
            //Person person3 = new Person("Ali", "Valiyev", 22);
            //Console.WriteLine(person3.IsAdult);

            //---------------------------------------Task2--------------------------------------------

            //Car car1 = new Car("BMW", "X5", "2010", "Disel", "Black");
            //Car car2 = new Car("AUDI", "Q7", "2018", "AI-95", "Bronze");
            //car1.PrintInfo();

            //---------------------------------------Task3--------------------------------------------

            //Car2 carOne = new Car2("BMW", "X5", "2010", 80, 5);

            //Motorcycle moto1= new Motorcycle("Meng", "HP4 RACE", "2023", 300, false);

            //if(carOne.MaxSpeed > 110) 
            //{
            //    Console.WriteLine("Suret oldurur");
            //}
            //else
            //{
            //    Console.WriteLine("Bele davam edin");
            //}


            //if (moto1.MaxSpeed > 110)
            //{
            //    Console.WriteLine("Suret oldurur");
            //}
            //else
            //{
            //    Console.WriteLine("Bele davam edin");
            //}


            //--------------------------------------------Task4------------------------------------------

            User user1 = new User("Aytac", "Seniorita", "a2b5c3.1");
            User user2 = new User("Aygun", "Seniorita", "aygun12");

            Console.WriteLine(user1.IsPasswordValid());
            Console.WriteLine(user2.IsPasswordValid());
        }
    }
}
