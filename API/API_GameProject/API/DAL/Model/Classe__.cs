using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace API.DAL.Model
{
    class Classe__
    {
        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }
    }
}
