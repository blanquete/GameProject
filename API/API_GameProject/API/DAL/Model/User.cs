using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using API.DAL.Service;


namespace API.DAL.Model
{
    public class User
    {
        [BsonId]
        public ObjectId O_Id { get; set; }

        [BsonElement("id")]
        public int Id { get; set; }

        [BsonElement("nickname")]
        public string nickname { get; set; }

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("last_name")]
        public string last_name { get; set; }

        [BsonElement("password")]
        public string password { get; set; }

        public User()
        {
            UserService objUserService = new UserService();

            Id = 0;
            nickname = "nickname";
            name = "name";
            last_name = "last_name";
            password = "123456";
        }

        public User(string name_, string last_name_, string password_)
        {
            UserService objUserService = new UserService();

            Id = 0;
            name = name_;
            last_name = last_name_;
            password = password_;
        }

        public User(int id_, string name_, string last_name_, string password_)
        {
            Id = id_;
            name = name_;
            last_name = last_name_;
            password = password_;
        }

    }


}
