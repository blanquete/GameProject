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
    [Route("api/classe")]
    [ApiController]
    public class TypeClassController : ControllerBase
    {
        // GET: user
        [HttpGet]
        public List<TypeClass> GetAll()
        {
            UserService objUserService = new UserService();
            return objUserService.GetAllTypeClass();
        }

        // GET user/5
        [HttpGet("{id}")]
        public TypeClass Get(int id)
        {
            UserService objUserService = new UserService();
            return objUserService.GetTypeClass(id);
        }

        // POST user
        [HttpPost]
        public bool Post([FromBody] TypeClass c)
        {
            UserService objUserService = new UserService();

            objUserService.AddTypeClass(c);

            return true;
        }

        // PUT user/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] TypeClass c)
        {
            UserService objUserService = new UserService();
            objUserService.UpdateTypeClass(c);
        }

        // DELETE user/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            UserService objUserService = new UserService();
            objUserService.DeleteTypeClass(id);
        }
    }
}
