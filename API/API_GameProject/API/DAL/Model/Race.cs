using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.DAL.Model
{
    public class Race
    {
        [BsonId]
        public ObjectId O_Id { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("description")]
        public string description { get; set; }

        [BsonElement("image")]
        public byte[] image { get; set; }
    }

    public class Race_Trait
    {
        [BsonId]
        public ObjectId O_Id { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("race_id")]
        public int race_id { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("description")]
        public string description { get; set; }
    }


}
