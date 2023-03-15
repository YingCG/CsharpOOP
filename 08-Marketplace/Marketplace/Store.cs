using System.Collections.Generic;

namespace Marketplace
{
    internal class Store
    {
        public List<Product> ProductList { get; set; }
        public List<Product> ShoppingList { get; set; }
        public Store()
        {
            ProductList = new List<Product>();
            ShoppingList = new List<Product>();
        }

        public decimal Checkout()
        {
            decimal totalCost = 0;
            foreach (var product in ShoppingList)
            {
                totalCost = totalCost + product.Price;
            }

            ShoppingList.Clear();
            return totalCost;
        }
    }
}