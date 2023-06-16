using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            teacher.FirstName = "Attaullah";
            teacher.LastName = "Khan";
            teacher.Age = 30;
            teacher.PhoneNumber = "0302-0000111";
            teacher.Qualification = "Bachelor in Computer Engineering";
            teacher.Salary = 50000;
            teacher.Details();

            Console.WriteLine("-------------------------------------------");


            Student student = new Student();
            student.FirstName = "Muhammad";
            student.LastName = "Sohaib";
            student.Age = 20;
            student.PhoneNumber = "0302-1111222";
            student.RollNo = 222;
            student.Fees = 10000;
            student.Details();
            Console.ReadLine();
        }
    }
}
