using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //account myAccount = new account();
            //myAccount.setBalance(100000);
            //myAccount.getBalance();
            //Console.ReadLine();






            Console.WriteLine("What you want from your account ?");
            string answer = Console.ReadLine();
            account myAccount = new account();
            if (answer == "add")
            {
                Console.WriteLine("Enter amount :");
                int number = int.Parse(Console.ReadLine());
                myAccount.setBalance(1000 + number);
                myAccount.getBalance();
            }
            else if(answer == "sub")
            {
                Console.WriteLine("Enter amount :");
                int number = int.Parse(Console.ReadLine());
                myAccount.setBalance(1000 - number);
                myAccount.getBalance();
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }
        }
    }
}
