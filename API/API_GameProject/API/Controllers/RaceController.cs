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
    [Route("api/race")]
    [ApiController]
    public class RaceController : ControllerBase
    {
        // GET: race
        [HttpGet]
        public List<Race> GetAll()
        {
            UserService objUserService = new UserService();
            return objUserService.GetAllRace();
        }

        // GET race/5
        [HttpGet("{id}")]
        public Race Get(int id)
        {
            UserService objUserService = new UserService();
            return objUserService.GetRace(id);
        }

        // POST race
        [HttpPost]
        public void Post([FromBody] Race r)
        {
            UserService objUserService = new UserService();

            objUserService.AddRace(r);
        }

        // PUT race/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Race r)
        {
            UserService objUserService = new UserService();
            objUserService.UpdateRace(r);
        }

        // DELETE race/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            UserService objUserService = new UserService();
            objUserService.DeleteRace(id);
        }
    }
}
