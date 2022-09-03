using System;

namespace OrderNotifications
{
    public class ProcessOrder
    {
        public void ProcessOrderFor(string name)
        {
            Console.WriteLine("There is an order from {0}", name);
        }
    }
}