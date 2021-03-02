using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chat_Room
{
    public class Email
    {
        [BsonId]
        public string email { get; set; }
    }
}
