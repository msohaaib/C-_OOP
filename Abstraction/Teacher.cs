using System;

class Teacher : Person
{
    public string Qualification;
    public int Salary;

    public override void Details()
    {
        string name = FirstName + " " + LastName;
        Console.WriteLine($"Teacher Name is {name}");
        Console.WriteLine($"Age is : {Age}");
        Console.WriteLine($"Phone Number is : {PhoneNumber}");
        Console.WriteLine($"Qualification is : {Qualification}");
        Console.WriteLine($"Salary is : {Salary}");
    }
}