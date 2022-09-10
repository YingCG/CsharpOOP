using System;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDBApp;
using MongoDBApp.DataAccess;
using MongoDBApp.Models;

namespace MongoDBApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ChoreDataAccess db = new ChoreDataAccess();

            //await db.CreateUser(new UserModel() { FirstName ="Slipppery", LastName="Skateboard" });

            var users = await db.GetAllUsers();

            var chore = new ChoreModel() {
                AssignedTo = users[1], 
                ChoreText = "To make art with the wind" , 
                FrequencyInDays = 7
            };

            await db.CreateChore(chore);

            var chores = await db.GetAllChores();
            await db.CompleteChore(chores[2]);

        }
    }
}
