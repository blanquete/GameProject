using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace API.DAL.Model
{
    public class MaxId
    {
        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]

        public ObjectId O_Id { get; set; }

        [BsonElement("taula")]
        public string taula { get; set; }

        [BsonElement("max_id")]
        public int max_id { get; set; }



        public MaxId()
        {
            taula = "";
            max_id = 1;
        }

        public MaxId(string taula_)
        {
            taula = taula_;
            max_id = 1;
        }

        public MaxId(string taula_, int max_id_)
        {
            taula = taula_;
            max_id = max_id_;
        }
    }
}
