using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.name = "Sohaib";
            std.mail = "Sohaib@hotmail.com";
            std.phone = 4321;
            std.English_marks = 85;
            std.Urdu_marks = 80;
            std.Computer_marks = 100;
            Console.WriteLine($"Name = {std.name}\nmail = {std.mail}\nphone = {std.phone}\nTotal Marks = {std.English_marks + std.Urdu_marks + std.Computer_marks}");
            
        }
    }
}
