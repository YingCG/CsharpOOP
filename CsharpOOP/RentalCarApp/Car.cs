using System;
using System.Collections.Generic;
using System.Text;

namespace RentalCarApp
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            this.Make = "store-pick";
            this.Model = "store-pick";
            this.Price = 39.99M;
        }

        public Car(string a, string b, decimal c)
        {
            this.Make = a;
            this.Model = b;
            this.Price = c;
        }

        public override string ToString()
        {
            return ("Make: " + Make + "| Model:" + Model + "| Price: $" + Price);
        }
    }
}
