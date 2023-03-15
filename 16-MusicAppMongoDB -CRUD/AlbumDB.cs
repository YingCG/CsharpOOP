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
            var setting = MongoClientSettings.FromConnectionString("mongodb+srv://curious-earthworm:hT4HYjBcZlsWs7Lf@byo-cup-corner.sqa3qxz.mongodb.net/?retryWrites=true&w=majority");
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


        public void SaveAlbum(Album album)
        {
            if (album.Id == null)
            {
                _client.GetDatabase("music-app")
                    .GetCollection<Album>("albums")
                    .InsertOne(album);
            }
            else
            {
                var builder = new FilterDefinitionBuilder<Album>();
                _client.GetDatabase("music-app")
                    .GetCollection<Album>("albums")
                    .ReplaceOne(builder.Eq(album => album.Id, album.Id), album);
            }
        }

        internal Album GetById(object id)
        {
            var builder = new FilterDefinitionBuilder<Album>();
            return _client.GetDatabase("music-app")
                .GetCollection<Album>("albums")
                .Find(builder.Eq(album => album.Id, id))
                .FirstOrDefault();
        }

        internal void DeleteById(object id)
        {
            var builder = new FilterDefinitionBuilder<Album>();
            _client.GetDatabase("music-app")
                .GetCollection<Album>("albums")
                .DeleteOne(builder.Eq(album => album.Id, id));
        }
    }
}
