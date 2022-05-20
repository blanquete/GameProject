using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using API.DAL.Model;
using API.DAL.Service;
using API.DAL.Persistance;

using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: user
        [HttpGet]
        public List<User> GetAll()
        {
            UserService objUserService = new UserService();
            return objUserService.GetAllUser();
        }

        // GET user/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            UserService objUserService = new UserService();
            return objUserService.GetUser(id);
        }

        // GET user/nickname
        [HttpGet("nickname/{nickname}")]
        public User Get(string nickname)
        {
            UserService objUserService = new UserService();
            return objUserService.GetUser(nickname);
        }

        // POST user
        [HttpPost]
        public bool Post([FromBody] User u)
        {
            UserService objUserService = new UserService();

            List<User> users = objUserService.GetAllUser();

            bool nom_unic = true;

            foreach(User us in users)
            {
                if(us.nickname == u.nickname)
                {
                    nom_unic = false;
                }
            }


            if(nom_unic)
            {
                objUserService.AddUser(u);
                return true;
            }
            else
            {
                Console.WriteLine("El nom no era unic");
            }
            return false;
        }

        // PUT user/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User u)
        {
            UserService objUserService = new UserService();
            objUserService.UpdateUser(u);
        }

        // DELETE user/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            UserService objUserService = new UserService();
            objUserService.DeleteUser(id);
        }
    }
}
