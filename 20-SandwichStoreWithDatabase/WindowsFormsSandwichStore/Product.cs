using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace WindowsFormsSandwichStore
{
    public class Product
    {
        public BsonObjectId Id { get; set; }

        public string Title { get; set; }
        public string Subtitle { get; set; }

        [BsonIgnore]
        public Image ProductImage { get; set; }

        public byte[] ImageBytes
        {
            get
            {
                var ms = new MemoryStream();
                ProductImage.Save(ms, ImageFormat.Png);
                ms.Seek(0, SeekOrigin.Begin);
                return ms.ToArray();
            }
            set
            {
                ProductImage = Image.FromStream(new MemoryStream(value));
            }
        }

        public Decimal Price { get; set; }
    }
}