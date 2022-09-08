namespace OrderNotifications
{
    public class OnlineOrder
    {
        // Declare Delegate
        public delegate void PublishOnlineOrder(string name);

        // Define Delegate
        public event PublishOnlineOrder OnOrderPublished = null;

        // Method use to Invoke Delegate
        public void PublishOrder(string name)
        {
            //Invoke Delegate
            OnOrderPublished.Invoke(name);
        }
        
    }
}