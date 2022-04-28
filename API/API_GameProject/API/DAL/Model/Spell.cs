using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.DAL.Model
{
    public class Spell
    {
        public string name { get; set; }
        public string description { get; set; }
        public string level { get; set; }
        public string casting_time { get; set; }
        public string range_area { get; set; }
        public string attack_save { get; set; }
        public string duration { get; set; }
        public string damage_effect { get; set; }
        public string[] components { get; set; }
        public string school { get; set; }
    }
}
