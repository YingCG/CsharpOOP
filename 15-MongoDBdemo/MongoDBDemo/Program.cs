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
            string connectionString = "mongodb://yingcg:evHOAQ0DG70Ebbxs@cluster0-shard-00-00.trnua.mongodb.net:27017,cluster0-shard-00-01.trnua.mongodb.net:27017,cluster0-shard-00-02.trnua.mongodb.net:27017/?ssl=true&replicaSet=atlas-me3wwk-shard-0&authSource=admin&retryWrites=true&w=majority";
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
