using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBApp.Models
{
    public class ChoreHistoryModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ChoreId { get; set; }
        public string ChoreText { get; set; }
        public int FrequencyInDays { get; set; }
        public DateTime? DateCompleted { get; set; }
        public UserModel? WhoCompleted { get; set; }
        public ChoreHistoryModel()
        {

        }

        public ChoreHistoryModel(ChoreModel chore)
        {
            ChoreId = chore.Id;
            DateCompleted = chore.LastCompleted ?? DateTime.Now;
            WhoCompleted = chore.AssignedTo;
            ChoreText = chore.ChoreText;
        }
    }
}
