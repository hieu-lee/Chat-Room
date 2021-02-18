using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Room
{
    public class Message
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("username")]
        public string username { get; set; }

        [BsonElement("content")]
        public string content { get; set; }

        [BsonElement("time")]
        public DateTime time { get; set; }

        [BsonElement("received")]
        public bool received { get; set; }

        [BsonElement("image")]
        public byte[] image { get; set; }

        public override string ToString()
        {
            return $"{username}: {content}";
        }
    }
}
