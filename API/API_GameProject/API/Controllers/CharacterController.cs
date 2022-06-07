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
    [Route("api/character")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        // GET: character
        [HttpGet]
        public List<Character> GetAll()
        {
            UserService objUserService = new UserService();
            return objUserService.GetAllCharacter();
        }

        // GET character/5
        [HttpGet("{id}")]
        public Character Get(int id)
        {
            UserService objUserService = new UserService();
            return objUserService.GetCharacter(id);
        }

        // POST character
        [HttpPost]
        public void Post([FromBody] Character c)
        {
            UserService objUserService = new UserService();
            objUserService.AddCharacter(c);
        }

        // PUT character/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Character c)
        {
            UserService objUserService = new UserService();
            objUserService.UpdateCharacter(c);
        }

        // DELETE character/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            UserService objUserService = new UserService();
            objUserService.DeleteCharacter(id);
        }
    }
}
