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
        public string name { get; set; }
        public string subtype { get; set; }
        public Race_Trait[] race_traits { get; set; }
    }

    public class Race_Trait
    {
        public string name { get; set; }
        public string description { get; set; }
    }


}
