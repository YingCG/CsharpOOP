using System;

namespace OrderNotifications
{
    public class ThankyouEmail
    {
        public void SendThankyouEmail(string name)
        {
            Console.WriteLine("Thank you for your order, {0}! We will dispatch your order within 3 working days." , name );
        }
    }
}