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

        [BsonElement("name")]
        public string name { get; set; }

        [BsonElement("last_name")]
        public string last_name { get; set; }

        [BsonElement("password")]
        public string password { get; set; }

        public User()
        {
            UserService objUserService = new UserService();
            MaxId aux = objUserService.GetMaxId("user");

            Id = aux.max_id;
            name = "Nom";
            last_name = "Cognoms";
            password = "123456";

            aux.max_id = aux.max_id + 1;
            objUserService.UpdateMaxId(aux);
        }

        public User(string name_, string last_name_, string password_)
        {
            UserService objUserService = new UserService();
            MaxId aux = objUserService.GetMaxId("user");

            Id = aux.max_id;
            name = name_;
            last_name = last_name_;
            password = password_;

            aux.max_id = aux.max_id + 1;
            objUserService.UpdateMaxId(aux);
        }

    }


}
