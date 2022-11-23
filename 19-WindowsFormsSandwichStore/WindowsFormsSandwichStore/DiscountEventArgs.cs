using System;

namespace WindowsFormsSandwichStore
{
    public delegate void DiscountEventHandler(object source, DiscountEventArgs e);

    public class DiscountEventArgs : EventArgs
    {
        public decimal DiscountPercentage { get; }

        public DiscountEventArgs(decimal discountPercentage)
        {
            DiscountPercentage = discountPercentage;
        }

    }
}