using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.DAL.Model
{
    public class Monsters
    {
        public Monster[] monsters { get; set; }
    }

    public class Monster
    {
        public string name { get; set; }
        public string slug { get; set; }
        public float challenge_rating { get; set; }
        public string size { get; set; }
        public string type { get; set; }
        public string subtype { get; set; }
        public string alignment { get; set; }
        public Armor_Class armor_class { get; set; }
        public Monster_Hit_Points Monster_hit_points { get; set; }
        public Speed speed { get; set; }
        public Ability_Scores ability_scores { get; set; }
        public Saving_Throws saving_throws { get; set; }
        public Skills skills { get; set; }
        public string[] languages { get; set; }
        public Senses senses { get; set; }
        public Trait[] traits { get; set; }
        public Action[] actions { get; set; }
        public string[] tags { get; set; }
        public string[] damage_immunities { get; set; }
        public string[] condition_immunities { get; set; }
        public string[] damage_resistances { get; set; }
        public string[] damage_vulnerabilities { get; set; }
    }


}
