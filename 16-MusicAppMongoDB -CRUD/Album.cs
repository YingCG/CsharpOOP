using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MusicAppMongoDB
{
    public class Album
    {
        [BsonId]
        public BsonObjectId Id { get; set; }
        public string AlbumName { get; set; }
        public string ArtistName { get; set; }
        public string Year { get; set; }
        public string ImageURL { get; set; }
        public string VideoPath { get; set; }
    }
}
