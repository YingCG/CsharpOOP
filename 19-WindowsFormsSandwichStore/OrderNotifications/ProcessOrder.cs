using System;

namespace OrderNotifications
{
    public class ProcessOrder
    {
        public void ProcessOrderFor(string name)
        {
            Console.WriteLine("Hi team, We have a new order");
            Console.WriteLine("Customer: {0}", name);
        }
    }
}