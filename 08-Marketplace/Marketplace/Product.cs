namespace Marketplace
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Inventory { get; set; }
        public decimal Price { get; internal set; }
        public Product(int id, string productName, int inventory, decimal price)
        {
            Id = id; 
            ProductName = productName;
            Inventory = inventory;
            Price = price;
        }

        public Product()
        {
        }

        public override string ToString()
        {
            return ("Product: " + ProductName + " Price: $" + Price);
        }
    }
}