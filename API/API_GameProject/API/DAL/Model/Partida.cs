using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

using API.DAL.Service;

namespace API.DAL.Model
{
    public class Partida
    {
        [BsonId]
        public ObjectId O_Id { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("code")]
        public string code { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("description")]
        public string description { get; set; }

        [BsonElement("characters_id")]
        public int[] characters_id { get; set; }

        [BsonElement("users_id")]
        public int[] users_id { get; set; }

        [BsonElement("game_master_id")]
        public int game_master_id { get; set; }

        [BsonElement("playing")]
        public bool playing { get; set; }

        [BsonElement("in_game")]
        public bool in_game { get; set; }

        [BsonElement("last_scene_id")]
        public int last_scene_id { get; set; }

        [BsonElement("current_user_id")]
        public int user_current_id { get; set; }
    }
}
