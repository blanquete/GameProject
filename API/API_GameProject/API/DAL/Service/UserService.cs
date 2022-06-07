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
        public void DeleteDice(int Id)
        {
            IMongoCollection<Dice> dices = DbContext.GetDices();

            var result = dices.DeleteOne(d => d.Id == Id);
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
            IMongoCollection<User> users = DbContext.GetUsers();

            User u = users.Find(u => u.Id == Id).FirstOrDefault();

            return u;
        }
        public User GetUser(string nickname)
        {
            IMongoCollection<User> users = DbContext.GetUsers();

            User u = users.Find(u => u.nickname == nickname).FirstOrDefault();

            return u;
        }
        public void AddUser(User u)
        {
            IMongoCollection<User> users = DbContext.GetUsers();

            UserService objUserService = new UserService();

            MaxId maxId = objUserService.GetMaxId("user");

            u.Id = maxId.max_id;

            users.InsertOne(u);

            objUserService.UpdateMaxId(maxId);
        }
        public void UpdateUser(User u)
        {
            IMongoCollection<User> users = DbContext.GetUsers();

            var filtre = Builders<User>.Filter.Eq(u => u.Id, u.Id);
            var result = users.ReplaceOne(filtre, u);
        }
        public void DeleteUser(int Id)
        {
            IMongoCollection<User> users = DbContext.GetUsers();

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

            mId.max_id += 1;

            var result = mIds.ReplaceOne(filtre, mId);
        }
        public void DeleteMaxId(string Id)
        {
            IMongoCollection<MaxId> mIds = DbContext.GetMaxIds();

            var result = mIds.DeleteOne(u => u.taula == Id);
        }



        /// <summary>
        /// PARTIDA
        /// 
        ///
        /// </summary>
        public List<Partida> GetAllPartida()
        {
            IMongoCollection<Partida> p = DbContext.GetPartides();

            List<Partida> result = p.AsQueryable<Partida>().ToList();
            return result;
        }
        public Partida GetPartida(int Id)
        {
            IMongoCollection<Partida> partides = DbContext.GetPartides();

            Partida p = partides.Find(p => p.Id == Id).FirstOrDefault();

            return p;
        }
        public void AddPartida(Partida p)
        {
            IMongoCollection<Partida> ps = DbContext.GetPartides();

            ps.InsertOne(p);
        }
        public void UpdatePartida(Partida p)
        {
            IMongoCollection<Partida> ps = DbContext.GetPartides();

            var filtre = Builders<Partida>.Filter.Eq(pa => pa.Id, p.Id);

            var result = ps.ReplaceOne(filtre, p);
        }
        public void DeletePartida(int Id)
        {
            IMongoCollection<Partida> ps = DbContext.GetPartides();

            var result = ps.DeleteOne(p => p.Id == Id);
        }


        public void OpenPartida(int Id)
        {
            Partida p = GetPartida(Id);

            p.online = true;

            UpdatePartida(p);
        }
        public void PlayPartida(int Id)
        {
            Partida p = GetPartida(Id);

            p.in_game = true;

            UpdatePartida(p);
        }
        public void StopPartida(int Id)
        {
            Partida p = GetPartida(Id);

            p.in_game = false;

            UpdatePartida(p);
        }
        public void ClosePartida(int Id)
        {
            Partida p = GetPartida(Id);

            p.online = false;

            UpdatePartida(p);
        }



        /// <summary>
        /// RACE
        /// 
        ///
        /// </summary>

        public List<Race> GetAllRace()
        {
            IMongoCollection<Race> r = DbContext.GetRaces();

            List<Race> result = r.AsQueryable<Race>().ToList();
            return result;
        }
        public Race GetRace(int Id)
        {
            IMongoCollection<Race> races = DbContext.GetRaces();

            Race r = races.Find(r => r.Id == Id).FirstOrDefault();

            return r;
        }
        public void AddRace(Race r)
        {
            IMongoCollection<Race> rs = DbContext.GetRaces();

            rs.InsertOne(r);
        }
        public void UpdateRace(Race r)
        {
            IMongoCollection<Race> rs = DbContext.GetRaces();

            var filtre = Builders<Race>.Filter.Eq(ra => ra.Id, r.Id);

            var result = rs.ReplaceOne(filtre, r);
        }
        public void DeleteRace(int Id)
        {
            IMongoCollection<Race> rs = DbContext.GetRaces();

            var result = rs.DeleteOne(r => r.Id == Id);
        }



        /// <summary>
        /// CLASSE
        /// 
        ///
        /// </summary>
        public List<TypeClass> GetAllTypeClass()
        {
            IMongoCollection<TypeClass> c = DbContext.GetTypeClasses();

            List<TypeClass> result = c.AsQueryable<TypeClass>().ToList();
            return result;
        }
        public TypeClass GetTypeClass(int Id)
        {
            IMongoCollection<TypeClass> classes = DbContext.GetTypeClasses();

            TypeClass c = classes.Find(c => c.Id == Id).FirstOrDefault();

            return c;
        }
        public void AddTypeClass(TypeClass c)
        {
            IMongoCollection<TypeClass> cs = DbContext.GetTypeClasses();

            cs.InsertOne(c);
        }
        public void UpdateTypeClass(TypeClass c)
        {
            IMongoCollection<TypeClass> cs = DbContext.GetTypeClasses();

            var filtre = Builders<TypeClass>.Filter.Eq(cl => cl.Id, c.Id);

            var result = cs.ReplaceOne(filtre, c);
        }
        public void DeleteTypeClass(int Id)
        {
            IMongoCollection<TypeClass> cs = DbContext.GetTypeClasses();

            var result = cs.DeleteOne(c => c.Id == Id);
        }



        /// <summary>
        /// SCENE
        /// 
        ///
        /// </summary>

        public List<Scene> GetAllScene()
        {
            IMongoCollection<Scene> s = DbContext.GetScenes();

            List<Scene> result = s.AsQueryable<Scene>().ToList();
            return result;
        }
        public Scene GetScene(int Id)
        {
            IMongoCollection<Scene> scenes = DbContext.GetScenes();

            Scene s = scenes.Find(s => s.Id == Id).FirstOrDefault();

            return s;
        }
        public void AddScene(Scene s)
        {
            IMongoCollection<Scene> ss = DbContext.GetScenes();

            ss.InsertOne(s);
        }
        public void UpdateScene(Scene s)
        {
            IMongoCollection<Scene> ss = DbContext.GetScenes();

            var filtre = Builders<Scene>.Filter.Eq(sc => sc.Id, s.Id);

            var result = ss.ReplaceOne(filtre, s);
        }
        public void DeleteScene(int Id)
        {
            IMongoCollection<Scene> ss = DbContext.GetScenes();

            var result = ss.DeleteOne(s => s.Id == Id);
        }



        /// <summary>
        /// CHARACTER
        /// 
        ///
        /// </summary>

        public List<Character> GetAllCharacter()
        {
            IMongoCollection<Character> c = DbContext.GetCharacters();

            List<Character> result = c.AsQueryable<Character>().ToList();
            return result;
        }
        public Character GetCharacter(int Id)
        {
            IMongoCollection<Character> characters = DbContext.GetCharacters();

            Character ch = characters.Find(c => c.Id == Id).FirstOrDefault();

            return ch;
        }
        public void AddCharacter(Character c)
        {
            IMongoCollection<Character> cs = DbContext.GetCharacters();

            cs.InsertOne(c);
        }
        public void UpdateCharacter(Character c)
        {
            IMongoCollection<Character> cs = DbContext.GetCharacters();

            var filtre = Builders<Character>.Filter.Eq(ch => ch.Id, c.Id);

            var result = cs.ReplaceOne(filtre, c);
        }
        public void DeleteCharacter(int Id)
        {
            IMongoCollection<Character> cs = DbContext.GetCharacters();

            var result = cs.DeleteOne(c => c.Id == Id);
        }
    }
}
