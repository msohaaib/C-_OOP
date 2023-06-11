using System;
// For Method over riding
class account1
{
    public void account01()
    {
        Console.WriteLine("this is account 01");
    }
}
class account2 : account1
{
    public void account01()
    {
        Console.WriteLine("this is account 02");
    }
}