using System.Collections.Generic;

namespace RentalCarGui
{
    public class Store
    {
        public List<Car> CarList { get; set; }
        public List<Car> ShoppingList { get; set; }

        public Store()
        {
            CarList = new List<Car>();
            ShoppingList = new List<Car>();
        }

        public decimal Checkout()
        {
            decimal totalCost = 0;
            foreach(var car in ShoppingList)
            {
                totalCost = totalCost + car.Price;
            }

            ShoppingList.Clear();
            return totalCost;
        }
    }
}