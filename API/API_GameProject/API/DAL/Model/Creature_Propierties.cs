using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace API.DAL.Model
{
    public class Armor_Class
    {
        public int value { get; set; }
        public string description { get; set; }
    }


    public class Background
    {
        public string name { get; set; }
    }

    public class Details
    {
        public string personality { get; set; }
        public string ideal { get; set; }
        public string bond { get; set; }
        public string flaw { get; set; }
    }

    public class Hit_Points
    {
        public int max { get; set; }
        public int current { get; set; }
    }

    public class Monster_Hit_Points//Hit Points dels monstres
    {
        public int max { get; set; }
        public Dice[] dice { get; set; }
    }

    public class Speed
    {
        public Speed_Type Walk { get; set; }
        public Speed_Type Burrow { get; set; }
        public Speed_Type Climb { get; set; }
        public Speed_Type Fly { get; set; }
        public Speed_Type Hover { get; set; }
        public Speed_Type Swim { get; set; }
    }

    public class Speed_Type
    {
        public bool aviable { get; set; }
        public int value { get; set; }
    }

    public class Ability_Scores
    {
        public int str { get; set; }
        public int dex { get; set; }
        public int con { get; set; }
        public int _int { get; set; }
        public int wis { get; set; }
        public int cha { get; set; }
    }

    public class Saving_Throws
    {
        public Saving_Throw str { get; set; }
        public Saving_Throw dex { get; set; }
        public Saving_Throw con { get; set; }
        public Saving_Throw _int { get; set; }
        public Saving_Throw wis { get; set; }
        public Saving_Throw cha { get; set; }
    }
    public class Saving_Throw
    {
        public bool aviable { get; set; }
        public int value { get; set; }
    }

    public class Skills
    {
        public Skill Athletics { get; set; }
        public Skill Acrobatics { get; set; }
        public Skill Stealth { get; set; }
        public Skill Arcana { get; set; }
        public Skill History { get; set; }
        public Skill Investigation { get; set; }
        public Skill Nature { get; set; }
        public Skill Religion { get; set; }
        public Skill Insight { get; set; }
        public Skill Medicine { get; set; }
        public Skill Perception { get; set; }
        public Skill Survival { get; set; }
        public Skill Deception { get; set; }
        public Skill Intimidation { get; set; }
        public Skill Performance { get; set; }
        public Skill Persuasion { get; set; }
        public Skill Sleight_of_Hand { get; set; }
        public Skill Animal_Handling { get; set; }
    }
    public class Skill
    {
        public bool aviable { get; set; }
        public int value { get; set; }
    }

    public class Senses
    {
        public string Darkvision { get; set; }
        public string Blindsight { get; set; }
        public string Truesight { get; set; }
        public string Tremorsense { get; set; }
    }

    public class Trait
    {
        public string name { get; set; }
        public string description { get; set; }
        public int attack_bonus { get; set; }
    }

    public class Action
    {
        public string name { get; set; }
        public string description { get; set; }
        public int attack_bonus { get; set; }
        public Damage_Dice damage_dice { get; set; }
        public bool legendary { get; set; }
        public bool reaction { get; set; }
    }

    public class Damage_Dice
    {
        public int sides { get; set; }
        public int count { get; set; }
        public int mod { get; set; }
    }
}
