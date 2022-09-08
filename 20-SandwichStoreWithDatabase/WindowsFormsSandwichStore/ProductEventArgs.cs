using System;

namespace WindowsFormsSandwichStore
{
    // This is our message envelope
    public sealed class ProductEventArgs : EventArgs
    {
        // This is our message content
        public ProductEventArgs(Product product)
        {
            Product = product;
        }

        public Product Product { get; }
    }
}