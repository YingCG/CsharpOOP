using System;
using System.Collections.Generic;
using System.Text;
using MongoDBApp.Models;
using MongoDB.Driver;
using System.Threading.Tasks;

namespace MongoDBApp.DataAccess
{
    public class ChoreDataAccess
    {
        private const string ConnectionString = "mongodb+srv://curious-earthworm:MROUbfaPA9AzemT1@byo-cup-corner.sqa3qxz.mongodb.net/?retryWrites=true&w=majority";
        private const string DatabaseName = "choreDB";
        private const string ChoreCollection = "chore_chart";
        private const string UserCollection = "users";
        private const string ChoreHistoryCollection = "chore_history";

        private IMongoCollection<T> ConnectToMongo<T>(in string collection)
        {
            var client = new MongoClient(ConnectionString);
            var db = client.GetDatabase(DatabaseName);
            return db.GetCollection<T>(collection);
        }

        public async Task<List<UserModel>> GetAllUsers()
        {
            var usersCollection = ConnectToMongo<UserModel>(UserCollection);
            var result = await usersCollection.FindAsync(_ => true);
            return result.ToList();
        }

        public async Task<List<ChoreModel>> GetAllChores()
        {
            var choresCollection = ConnectToMongo<ChoreModel>(ChoreCollection);
            var result = await choresCollection.FindAsync(_ => true);
            return result.ToList();
        }

        public async Task<List<ChoreModel>> GetAllChoresForOne(UserModel user)
        {
            var choresCollection = ConnectToMongo<ChoreModel>(ChoreCollection);
            var result = await choresCollection.FindAsync(c => c.AssignedTo.Id == user.Id);
            return result.ToList();
        }

        public Task CreateUser(UserModel user)
        {
            var usersCollection = ConnectToMongo<UserModel>(UserCollection);
            return usersCollection.InsertOneAsync(user);
        }

        public Task CreateChore(ChoreModel chore)
        {
            var choresCollection = ConnectToMongo<ChoreModel>(ChoreCollection);
            return choresCollection.InsertOneAsync(chore);
        }

        public Task UpdateChore(ChoreModel chore)
        {
            var choresCollection = ConnectToMongo<ChoreModel>(ChoreCollection);
            var filter = Builders<ChoreModel>.Filter.Eq("Id", chore.Id);
            return choresCollection.ReplaceOneAsync(filter, chore, new ReplaceOptions { IsUpsert = true });
        }

        public Task DeleteChore(ChoreModel chore)
        {
            var choresCollection = ConnectToMongo<ChoreModel>(ChoreCollection);
            return choresCollection.DeleteOneAsync(c => c.Id == chore.Id);
        }

        public async Task CompleteChore(ChoreModel chore)
        {
            //var choresCollection = ConnectToMongo<ChoreModel>(ChoreCollection);
            //var filter = Builders<ChoreModel>.Filter.Eq("Id", chore.Id);
            //await choresCollection.ReplaceOneAsync(filter, chore);

            //var choreHistoryCollection = ConnectToMongo<ChoreHistoryModel>(ChoreHistoryCollection);
            //await choreHistoryCollection.InsertOneAsync(new ChoreHistoryModel(chore));


            // Below are example of transaction
            var client = new MongoClient(ConnectionString);
            using var session = await client.StartSessionAsync();

            session.StartTransaction();

            // If error happen in the way 
            try
            {
                var db = client.GetDatabase(DatabaseName);
                var choresCollection = db.GetCollection<ChoreModel>(ChoreCollection);
                var filter = Builders<ChoreModel>.Filter.Eq("Id", chore.Id);
                await choresCollection.ReplaceOneAsync(filter, chore);

                var choreHistoryCollection = db.GetCollection<ChoreHistoryModel>(ChoreHistoryCollection);
                await choreHistoryCollection.InsertOneAsync(new ChoreHistoryModel(chore));

                await session.CommitTransactionAsync();
            }
            catch (Exception ex)
            {
                await session.AbortTransactionAsync();
                Console.WriteLine(ex.Message);
            }
        }
    }
}
