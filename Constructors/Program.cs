using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // with CONSTRUCTOR

            //Car car = new Car("mustang", "Black", 2017);
            //Car sports = new Car("Ferrari", "Red", 2015);
            //Car royal = new Car("Rolls-Royce", "Silver", 1964);

            //Console.WriteLine($"I have {car.carColor} {car.carName} {car.carModel} model.");
            //Console.WriteLine($"I have {sports.carColor} {sports.carName} {sports.carModel} model.");
            //Console.WriteLine($"I have {royal.carColor} {royal.carName} {royal.carModel} model.");
            //Console.ReadLine();


            // without CONSTRUCTOR

            Car car = new Car();
            car.carName = "mustang";
            car.carColor = "Black";
            car.carModel = 2015;
            Console.WriteLine($"i have {car.carColor} {car.carName} {car.carModel} model.");
            Console.ReadLine();
        }
        }
}

