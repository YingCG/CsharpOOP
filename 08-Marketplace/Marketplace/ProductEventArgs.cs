using System;

namespace Marketplace
{
    public class ProductEventArgs : EventArgs
    {
        public ProductEventArgs(Product product)
        {
            Product = product;
        }

        public Product Product { get; }
    }
}
