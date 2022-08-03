using System;
using CsharpOOP.Classes;

namespace CsharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount bankAccount1 = new BankAccount(1245.21f, "Jimmy");

            BankAccount bankAccount2 = new ChildBankAccount(124.25f, "Jenny", "Jimmy");

            Console.WriteLine(SimpleMath.Add(23.22f, 12.55f));
            Console.WriteLine(bankAccount1.AddBalance(100f));
            Console.WriteLine(bankAccount2.AddBalance(-1300f));
            Console.WriteLine(bankAccount2.AddBalance(-5f));

            var text = new Text();
            text.Width = 100;
            text.Copy();
            Console.ReadLine();
        }
    }

    interface IOperations
    {

    }
}
