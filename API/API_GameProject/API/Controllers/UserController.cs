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

        // POST user
        [HttpPost]
        public void Post([FromBody] User u)
        {
            User x = new User("Raul", "Blanco", "12345");

            UserService objUserService = new UserService();
            //objUserService.AddUser(u);
            objUserService.AddUser(x);
        }

        // PUT user/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] User u)
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
