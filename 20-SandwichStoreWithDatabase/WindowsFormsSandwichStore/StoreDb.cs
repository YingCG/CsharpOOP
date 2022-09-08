using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsSandwichStore
{
    class StoreDb
    {
        private MongoClient _client;

        public StoreDb()
        {
            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://curious-earthworm:<password>@byo-cup-corner.sqa3qxz.mongodb.net/?retryWrites=true&w=majority");
            settings.ServerApi = new ServerApi(ServerApiVersion.V1);
            _client = new MongoClient(settings);
        }

        //public void Prepare()
        //{
        //    IEnumerable<Product> products = new List<Product>
        //    {
        //        new Product
        //        {
        //            Title = "Sandwich",
        //            Subtitle = "With your choice of protein",
        //            ProductImage = Properties.Resources.sandwich
        //        },
        //        new Product
        //        {
        //            Title = "Fries",
        //            Subtitle = "Fries with herb or spice",
        //            ProductImage = Properties.Resources.fries

        //        },
        //        new Product
        //        {
        //            Title = "Drink",
        //            Subtitle = "Fresh fruit juice",
        //            ProductImage = Properties.Resources.drinks
        //        }
        //    };

        //    _client
        //       .GetDatabase("sandwich-store")
        //       .DropCollection("products");

        //    _client
        //       .GetDatabase("sandwich-store")
        //       .GetCollection<Product>("products")
        //       .InsertMany(products);
        //}

        public List<Product> GetProducts()
        {
            return _client
                .GetDatabase("sandwich-store")
                .GetCollection<Product>("products")
                .Find(FilterDefinition<Product>.Empty)
                .ToList();
        }
    }
}
