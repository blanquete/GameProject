using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace API.DAL.Model
{
    public class Scene
    {

        [BsonId]
        public ObjectId O_Id { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("partida_id")]
        public int partida_id { get; set; }

        [BsonElement("image")]
        public byte[] image { get; set; }

        [BsonElement("num")]
        public int num { get; set; }

        [BsonElement("monsters")]
        public Monster [] monsters { get; set; }
    }
}
