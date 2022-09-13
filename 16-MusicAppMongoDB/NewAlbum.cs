using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MusicAppMongoDB
{
    public class NewAlbum
    {
        public BsonObjectId Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTimeOffset CreatedAt { get; set; }

        [BsonRepresentation(BsonType.DateTime)]
        public DateTimeOffset UpdatedAt { get; set; }
    }
}