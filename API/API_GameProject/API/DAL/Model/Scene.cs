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
        public ObjectId O_Id { get; set; }
        public int Id { get; set; }
        public int partida_id { get; set; }
        public byte[] image { get; set; }
        public int num { get; set; }
        public Monster [] monsters { get; set; }
    }
}
