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
    [Route("api/partida")]
    [ApiController]
    public class PartidaController : ControllerBase
    {
        // GET: partida
        [HttpGet]
        public List<Partida> GetAll()
        {
            UserService objUserService = new UserService();
            return objUserService.GetAllPartida();
        }

        // GET partida/5
        [HttpGet("{id}")]
        public Partida Get(int id)
        {
            UserService objUserService = new UserService();
            return objUserService.GetPartida(id);
        }

        // POST partida
        [HttpPost]
        public void Post([FromBody] Partida p)
        {
            UserService objUserService = new UserService();
            
            objUserService.AddPartida(p);
        }

        // PUT partida/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Partida p)
        {
            UserService objUserService = new UserService();
            objUserService.UpdatePartida(p);
        }

        // DELETE partida/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            UserService objUserService = new UserService();
            objUserService.DeletePartida(id);
        }
    }
}
