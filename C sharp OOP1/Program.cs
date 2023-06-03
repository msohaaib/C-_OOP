using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace C_sharp_OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what you want ?");
            string fValue = Console.ReadLine();
            student std = new student();
            Food fd = new Food();
            if(fValue == "student")
            {
                Console.WriteLine("What in student data ?");
                string stdata = Console.ReadLine();
                if(stdata == "name")
                {
                    Console.WriteLine(std.name);
                    Console.ReadLine();
                }
                else if (stdata == "mail")
                {
                    Console.WriteLine(std.mail);
                    Console.ReadLine();
                }
                else if (stdata == "age")
                {
                    Console.WriteLine(std.age);
                    Console.ReadLine();
                }
                else if (stdata == "marks")
                {
                    Console.WriteLine(std.marks);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong Entry");
                    Console.ReadLine();
                }
            }
            else if(fValue == "food")
            {
                Console.WriteLine("What will you like to Eat ?");
                string fditem = Console.ReadLine();
                if(fditem == "fastfood")
                {
                    Console.WriteLine(fd.fastfood);
                    Console.ReadLine();
                }
                else if (fditem == "colddrink")
                {
                    Console.WriteLine(fd.colddrink);
                    Console.ReadLine();
                }
                else if (fditem == "desi")
                {
                    Console.WriteLine(fd.desi);
                    Console.ReadLine();
                }
                else if (fditem == "chinese")
                {
                    Console.WriteLine(fd.chinese);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Wrong Entry");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Wrong Entry");
                Console.ReadLine();
            }
        }
    }
}
