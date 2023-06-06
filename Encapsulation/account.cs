using System;

class account
{
    private int accountBalance = 1000;

    public void setBalance(int amout)
    {
        accountBalance = amout;    
    }
    public void getBalance()
    {
        Console.WriteLine($"Your account balance is {accountBalance}");
    }
}
