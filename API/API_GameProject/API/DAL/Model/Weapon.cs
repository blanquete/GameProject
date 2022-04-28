using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.DAL.Model
{
    public class Weapon
    {
        public string name { get; set; }
        public Damage damage { get; set; }
        public bool equipped { get; set; }
        public Weapon_Properties weapon_properties { get; set; }
        public Throw_Range throw_range { get; set; }
    }

    public class Damage
    {
        public Dice dice { get; set; }
        public string type { get; set; }
    }

    public class Weapon_Properties
    {
        public bool Versatile { get; set; }
        public bool Finesse { get; set; }
        public bool Light { get; set; }
        public bool Thrown { get; set; }
    }

    public class Throw_Range
    {
        public int _short { get; set; }
        public int _long { get; set; }
    }

}
