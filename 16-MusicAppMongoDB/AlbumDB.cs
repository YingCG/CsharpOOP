using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;

namespace MusicAppMongoDB
{
    class AlbumDB
    {
        private MongoClient _client;

        public AlbumDB()
        {
            var setting = MongoClientSettings.FromConnectionString("mongodb+srv://curious-earthworm:MROUbfaPA9AzemT1@byo-cup-corner.sqa3qxz.mongodb.net/?retryWrites=true&w=majority");
            setting.ServerApi = new ServerApi(ServerApiVersion.V1);
            _client = new MongoClient(setting);
        }


        public List<Album> GetAlbums()
        {
            return _client
                .GetDatabase("music-app")
                .GetCollection<Album>("albums")
                .Find(FilterDefinition<Album>.Empty)
                .ToList();
        }
    }
}
