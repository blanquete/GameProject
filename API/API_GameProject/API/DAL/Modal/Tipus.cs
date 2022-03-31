using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.DAL.Model
{
    class Tipus
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("source")]
        public string Source { get; set; }

        [BsonElement("condition")]
        public string Condition { get; set; }

        [BsonElement("chatFlavor")]
        public string ChatFlavor { get; set; }

        [BsonElement("requirements")]
        public string Requirements { get; set; }
    }
}
