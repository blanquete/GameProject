using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.DAL.Model
{
    public class Type_Class
    {
        public string name { get; set; }
        public string subtype { get; set; }
        public int level { get; set; }
        public int hit_die { get; set; }
        public string spellcasting { get; set; }
        public Class_Feature[] features { get; set; }
    }

    public class Class_Feature
    {
        public string name { get; set; }
        public string description { get; set; }
    }
}
