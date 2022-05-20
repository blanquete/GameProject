using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.DAL.Model
{
    public class TypeClass
    {
        [BsonId]
        public ObjectId O_Id { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("subtype")]
        public string subtype { get; set; }

        [BsonElement("level")]
        public int level { get; set; }

        [BsonElement("hit_die")]
        public int hit_die { get; set; }

        [BsonElement("spellcasting")]
        public string spellcasting { get; set; }

        [BsonElement("features")]
        public Class_Feature[] features { get; set; }
    }

    public class Class_Feature
    {
        [BsonId]
        public ObjectId O_Id { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("description")]
        public string description { get; set; }
    }
}
