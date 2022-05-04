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

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("description")]
        public string description { get; set; }

        [BsonElement("characters_id")]
        public int[] characters_id { get; set; }

        [BsonElement("game_master_id")]
        public int game_master_id { get; set; }

        /*public Partida()
        {
            name = "Nom";
            last_name = "Cognoms";
            password = "123456";
        }

        public Partida(string name_, string last_name_, string password_)
        {
            name = name_;
            last_name = last_name_;
            password = password_;
        }*/
    }
}
