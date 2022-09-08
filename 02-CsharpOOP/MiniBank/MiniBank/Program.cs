using System;
using MiniBank.Classes;

namespace MiniBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var account = new BankAccount("Kendra", 1000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");

            account.MakeWithdrawal(120, DateTime.Now, "Laptop bag");
            Console.WriteLine(account.Balance);

            //check if initial balances must be positive.
            try
            {
                //var invalidAccount = new BankAccount("invalid", -55);
                account.MakeDeposit(-300, DateTime.Now, "Debit");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Exception caught creating account with negative balance");
                Console.WriteLine(e.ToString());
            }
            account.MakeWithdrawal(120, DateTime.Now, "Laptop bag");
        }
    }
}
