using System;

class Student : Person
{
    public int RollNo;
    public int Fees;

    public override void Details()
    {
        string name = FirstName + " " + LastName;
        Console.WriteLine($"Student Name is {name}");
        Console.WriteLine($"Student age is : {Age}");
        Console.WriteLine($"Student Phone Number is : {PhoneNumber}");
        Console.WriteLine($"Student Roll No is : {RollNo}");
        Console.WriteLine($"Student Fee is : {Fees}");
    }
}