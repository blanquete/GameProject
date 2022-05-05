using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace API.DAL.Model
{
    public class Character
    {
        [BsonId]
        public ObjectId O_Id { get; set; }

        [BsonElement("id")]
        public int id { get; set; }

        [BsonElement("user_id")]
        public int user_id { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("race_id")]
        public int race_id { get; set; }

        [BsonElement("type_class_id")]
        public int type_class_id { get; set; }

        [BsonElement("alignment")]
        public string alignment { get; set; }

        [BsonElement("speed")]
        public Speed speed { get; set; }

        [BsonElement("hit_points")]
        public Hit_Points hit_points { get; set; }

        [BsonElement("ability_scores")]
        public Ability_Scores ability_scores { get; set; }

        [BsonElement("skills")]
        public Skills skills { get; set; }

        [BsonElement("armor_class")]
        public Armor_Class armor_class { get; set; }

        [BsonElement("saving_throws")]
        public Saving_Throws saving_throws { get; set; }

        [BsonElement("languages")]
        public string[] languages { get; set; }

        [BsonElement("background")]
        public string background { get; set; }

        [BsonElement("details")]
        public Details details { get; set; }

        [BsonElement("weapons_id")]
        public int[] weapons_id { get; set; }

        [BsonElement("spells_id")]
        public int[] spells_id { get; set; }
    }
}
