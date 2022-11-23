using System;

namespace WindowsFormsSandwichStore
{
    public class DiscountEventArgs : EventArgs
    {
        public DiscountEventArgs(decimal discountPercentage)
        {
            DiscountPercentage = discountPercentage;
        }

        public decimal DiscountPercentage { get; }
    }
}