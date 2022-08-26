using System;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDBDemo;

namespace MongoDBDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string connectionString = "your connection string";
            string databaseName = "simple_db";
            string collectionName = "people";

            var client = new MongoClient(connectionString);
            var db = client.GetDatabase(databaseName);
            var collection = db.GetCollection<PersonModel>(collectionName);

            var person = new PersonModel { FirstName = "Timothy", LastName = "Grey" };
            await collection.InsertOneAsync(person);

            var results = await collection.FindAsync(_ => true);
            foreach (var result in results.ToList())
            {
                Console.WriteLine(value: $"{result.Id}: {result.FirstName} {result.LastName}");
            };
        }
    }
}
