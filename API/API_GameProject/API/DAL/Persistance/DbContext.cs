using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Driver;

using API.DAL.Model;

namespace API.DAL.Persistance
{
    /// <summary>
    /// Aqui es on recuperem les col·leccions de la Base de Dades.
    /// 
    /// Primer de tot tenim el GetInstance() per optenir una connexio a la Base de Dades de MongoDB,
    /// i a partir d'aquest despres tenim un metode per recuperar cada una de les diferents col·leccions.
    /// 
    /// 
    /// Els metodes que tenim, per ordre son aquests:
    /// 
    /// GetDice                 --> Recupera els diferents Daus que hi ha
    /// GetSpells               --> Recupera tots els Encanteris
    /// GetWeapons              --> Recupera totes les Armes
    /// GetType_Classes         --> Recupera totes les Classes
    /// GetRaces                --> Recupera totes les Races
    /// GetCharacters           --> Recupera tots els Personatges
    /// GetMonsters             --> Recupera tots els Monstres
    /// 
    /// </summary>
    public class DbContext
    {
        public static IMongoDatabase GetInstance()
        {
            string connectionString = "mongodb+srv://gameMaster:12345@gamecluster.bdbaf.mongodb.net/test";
            MongoClient mongoClient = new MongoClient(connectionString);
            return mongoClient.GetDatabase("GameDataBase");
        }

        public static IMongoCollection<User> GetUsers()
        {
            return GetInstance().GetCollection<User>("user");
        }

        public static IMongoCollection<MaxId> GetMaxIds()
        {
            return GetInstance().GetCollection<MaxId>("maxId");
        }

        public static IMongoCollection<Dice> GetDices()
        {
            return GetInstance().GetCollection<Dice>("dice");
        }

        public static IMongoCollection<Spell> GetSpells()
        {
            return GetInstance().GetCollection<Spell>("spell");
        }

        public static IMongoCollection<Weapon> GetWeapons()
        {
            return GetInstance().GetCollection<Weapon>("weapon");
        }

        public static IMongoCollection<TypeClass> GetTypeClasses()
        {
            return GetInstance().GetCollection<TypeClass>("type_class");
        }

        public static IMongoCollection<Race> GetRaces()
        {
            return GetInstance().GetCollection<Race>("race");
        }

        public static IMongoCollection<Character> GetCharacters()
        {
            return GetInstance().GetCollection<Character>("character");
        }

        public static IMongoCollection<Monster> GetMonsters()
        {
            return GetInstance().GetCollection<Monster>("monster");
        }
        public static IMongoCollection<Partida> GetPartides()
        {
            return GetInstance().GetCollection<Partida>("partida");
        }

        /*
        public static IMongoCollection<--------> Get--------()
        {
            return GetInstance().GetCollection<-------->("--------");
        }

        public static IMongoCollection<--------> Get--------()
        {
            return GetInstance().GetCollection<-------->("--------");
        }

        public static IMongoCollection<--------> Get--------()
        {
            return GetInstance().GetCollection<-------->("--------");
        }

        public static IMongoCollection<--------> Get--------()
        {
            return GetInstance().GetCollection<-------->("--------");
        }

        public static IMongoCollection<--------> Get--------()
        {
            return GetInstance().GetCollection<-------->("--------");
        }

        public static IMongoCollection<--------> Get--------()
        {
            return GetInstance().GetCollection<-------->("--------");
        }

        public static IMongoCollection<--------> Get--------()
        {
            return GetInstance().GetCollection<-------->("--------");
        }

        public static IMongoCollection<--------> Get--------()
        {
            return GetInstance().GetCollection<-------->("--------");
        }

        public static IMongoCollection<--------> Get--------()
        {
            return GetInstance().GetCollection<-------->("--------");
        }

        public static IMongoCollection<--------> Get--------()
        {
            return GetInstance().GetCollection<-------->("--------");
        }

        public static IMongoCollection<--------> Get--------()
        {
            return GetInstance().GetCollection<-------->("--------");
        }
        */

    }
}
