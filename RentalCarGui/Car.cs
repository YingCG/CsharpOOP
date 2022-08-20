namespace RentalCarGui
{
    public class Car
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car()
        {
            this.Make = "store-pick";
            this.Model = "store-pick";
            this.Price = 39.99M;
        }

        public Car(int id, string make, string model, decimal price)
        {
            this.Id = id;
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }

        public override string ToString()
        {
            return ("Make: " + Make + "  Model: " + Model + " Price: $" + Price);
        }
    }
}