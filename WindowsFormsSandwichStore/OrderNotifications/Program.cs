using System;

namespace OrderNotifications
{
    class Program
    {
        static void Main(string[] args)
        {
            // sender of the event
            OnlineOrder order = new OnlineOrder();

            // receipients
            ThankyouEmail toCustomer = new ThankyouEmail();
            ProcessOrder notifyTeam = new ProcessOrder();


            // subcribe to the event
            order.OnOrderPublished += toCustomer.SendThankyouEmail;
            order.OnOrderPublished += notifyTeam.ProcessOrderFor;

            // method that trigger/raise the event
            order.PublishOrder("Mori");
        }
    }
}
