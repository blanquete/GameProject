using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using API.DAL.Model;
using API.DAL.Service;

using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [Route("api/dice")]
    [ApiController]
    public class DiceController : ControllerBase
    {
        // GET: dice
        [HttpGet]
        public List<Dice> GetAll()
        {
            UserService objUserService = new UserService();
            return objUserService.GetAllDice();
        }

        // GET dice/5
        [HttpGet("{id}")]
        public Dice Get(string id)
        {
            UserService objUserService = new UserService();
            return objUserService.GetDice(id);
        }

        // POST dice
        [HttpPost]
        public void Post([FromBody] Dice d)
        {
            UserService objUserService = new UserService();
            objUserService.AddDice(d);
        }

        // PUT dice/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Dice d)
        {
            UserService objUserService = new UserService();
            objUserService.UpdateDice(d);
        }

        // DELETE dice/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            UserService objUserService = new UserService();
            objUserService.DeleteDice(id);
        }
    }
}
