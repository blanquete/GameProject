using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.DAL.Model
{
    public class Character
    {
        public string name { get; set; }
        public Player player { get; set; }
        public Race race { get; set; }
        public Type_Class[] type_class { get; set; }
        public string alignment { get; set; }
        public Speed speed { get; set; }
        public Hit_Points hit_points { get; set; }
        public Ability_Scores ability_scores { get; set; }
        public Skills skills { get; set; }
        public Armor_Class armor_class { get; set; }
        public Saving_Throws saving_throws { get; set; }
        public string[] languages { get; set; }
        public Background background { get; set; }
        public Details details { get; set; }
        public Weapon[] weapons { get; set; }
        public Spell[] spells { get; set; }
    }

    public class Player
    {
        public string name { get; set; }
    }
}
