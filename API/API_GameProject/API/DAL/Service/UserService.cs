using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MongoDB.Bson;
using MongoDB.Driver;

using API.DAL.Model;
using API.DAL.Persistance;


namespace API.DAL.Service
{
    public class UserService
    {
        /// <summary>
        /// DICE
        /// 
        ///
        /// </summary>

        public List<Dice> GetAllDice()
        {
            IMongoCollection<Dice> dices = DbContext.GetDices();

            List<Dice> result = dices.AsQueryable<Dice>().ToList();
            return result;
        }

        public Dice GetDice(int Id)
        {
            UserService objUserService = new UserService();
            List<Dice> ds = objUserService.GetAllDice();

            //ObjectId ID = new ObjectId(Id);

            foreach (Dice d in ds)
            {
                if (d.Id == Id)
                {
                    return d;
                }
            }

            return null;
        }

        public void AddDice(Dice d)
        {
            IMongoCollection<Dice> dices = DbContext.GetDices();

            dices.InsertOne(d);
        }

        public void UpdateDice(Dice d)
        {
            IMongoCollection<Dice> dices = DbContext.GetDices();

            var filtre = Builders<Dice>.Filter.Eq(d => d.Id, d.Id);
            var result = dices.ReplaceOne(filtre, d);
        }

        public void DeleteDice(int Id)//(ObjectId Id)
        {
            IMongoCollection<Dice> dices = DbContext.GetDices();

            //ObjectId ID = new ObjectId(Id);

            var result = dices.DeleteOne(s => s.Id == Id);//(s => s.Id == Id);
        }



        /// <summary>
        /// USER
        /// 
        ///
        /// </summary>

        public List<User> GetAllUser()
        {
            IMongoCollection<User> users = DbContext.GetUsers();

            List<User> result = users.AsQueryable<User>().ToList();
            return result;
        }

        public User GetUser(int Id)
        {
            UserService objUserService = new UserService();
            List<User> us = objUserService.GetAllUser();

            //ObjectId ID = new ObjectId(Id);

            foreach (User u in us)
            {
                if (u.Id == Id)
                {
                    return u;
                }
            }

            return null;
        }

        public void AddUser(User u)
        {
            IMongoCollection<User> users = DbContext.GetUsers();

            users.InsertOne(u);
        }

        public void UpdateUser(User u)
        {
            IMongoCollection<User> users = DbContext.GetUsers();

            var filtre = Builders<User>.Filter.Eq(u => u.Id, u.Id);
            var result = users.ReplaceOne(filtre, u);
        }

        public void DeleteUser(int Id)//(ObjectId Id)
        {
            IMongoCollection<User> users = DbContext.GetUsers();

            //ObjectId ID = new ObjectId(Id);

            var result = users.DeleteOne(u => u.Id == Id);
        }



        /// <summary>
        /// MAXID
        /// 
        ///
        /// </summary>

        public List<MaxId> GetAllMaxId()
        {
            IMongoCollection<MaxId> mIds = DbContext.GetMaxIds();

            List<MaxId> result = mIds.AsQueryable<MaxId>().ToList();
            return result;
        }

        public MaxId GetMaxId(string Id)
        {
            UserService objUserService = new UserService();
            List<MaxId> mIds = objUserService.GetAllMaxId();

            foreach (MaxId mId in mIds)
            {
                if (mId.taula == Id)
                {
                    return mId;
                }
            }

            return null;
        }

        public void AddMaxId(MaxId mId)
        {
            IMongoCollection<MaxId> mIds = DbContext.GetMaxIds();

            mIds.InsertOne(mId);
        }

        public void UpdateMaxId(MaxId mId)
        {
            IMongoCollection<MaxId> mIds = DbContext.GetMaxIds();

            var filtre = Builders<MaxId>.Filter.Eq(mId => mId.taula, mId.taula);
            var result = mIds.ReplaceOne(filtre, mId);
        }

        public void DeleteMaxId(string Id)//(ObjectId Id)
        {
            IMongoCollection<MaxId> mIds = DbContext.GetMaxIds();

            //ObjectId ID = new ObjectId(Id);

            var result = mIds.DeleteOne(u => u.taula == Id);
        }
    }
}
