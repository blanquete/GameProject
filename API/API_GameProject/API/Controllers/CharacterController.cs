using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using API.DAL.Model;
using API.DAL.Service;
using API.DAL.Persistance;

using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Controladores sirven para saber en que ruta se encuentra la informacion. 
/// </summary>
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

        // GET character/nickname
        [HttpGet("nickname/{nickname}")]
        public Character Get(string nickname)
        {
            UserService objUserService = new UserService();
            return objUserService.GetCharacter(nickname);
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
