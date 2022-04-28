using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

//using API.DAL.Service;


namespace API.DAL.Model
{
    /// <summary>
    /// 
    /// La classe Dice (Dau), es la classe que servira per simular els daus de la partida, al mon dels jocs de rol hi poden haver tirades de daus de diferent numero de cares
    /// per tant hem de controlar, les cares dels daus, els copas que hem de tirar el dau, i si te algun modificador extra.
    /// 
    /// </summary>



    public class Dice
    {
        [BsonId]
        //[BsonRepresentation(BsonType.ObjectId)]

        public ObjectId O_Id { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("sides")]
        public int sides { get; set; }

        [BsonElement("count")]
        public int count { get; set; }

        [BsonElement("mod")]
        public int mod { get; set; }

        public Dice()
        {
            sides = 6;
            count = 1;
            mod = 0;
        }
        
        public Dice(int sides_, int count_)
        {
            sides = sides_;
            count = count_;
            mod = 0;
        }

        public Dice(int sides_, int count_, int mod_)
        {
            sides = sides_;
            count = count_;
            mod = mod_;
        }

        public int Throw_Dice(Dice d)
        {
            int value = 0;
            Random r = new Random();

            for(int i = 0; i < d.count; i++)
            {
                value += r.Next(1, d.sides+1);
            }

            value += d.mod;

            return value;
        }

        public int Throw_Dices(Dice[] di)
        {
            int value = 0;
            
            foreach(Dice d in di)
            {
                value += Throw_Dice(d);
            }

            return value;
        }
    }

}
