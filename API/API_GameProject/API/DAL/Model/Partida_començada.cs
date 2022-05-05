using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace API.DAL.Model
{
    public class Partida_començada
    {
        [BsonId]
        public ObjectId O_Id { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("partida_id")]
        public int partida_id { get; set; }

        [BsonElement("playing")]
        public bool playing { get; set; }

        [BsonElement("in_game")]
        public string in_game { get; set; }

        [BsonElement("last_scene_id")]
        public int last_scene_id { get; set; }
    }
}
