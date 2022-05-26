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





        // GET partida/openPartida/5
        [HttpGet("openPartida/{id}")]
        public void OpenPartida(int id, [FromBody] Partida p)
        {
            UserService objUserService = new UserService();
            objUserService.OpenPartida(p.Id);
        }

        // GET partida/playPartida/5
        [HttpGet("playPartida/{id}")]
        public void PlayPartida(int id, [FromBody] Partida p)
        {
            UserService objUserService = new UserService();
            objUserService.PlayPartida(p.Id);
        }

        // GET partida/closePartida/5
        [HttpGet("closePartida/{id}")]
        public void ClosePartida(int id, [FromBody] Partida p)
        {
            UserService objUserService = new UserService();
            objUserService.ClosePartida(p.Id);
        }

        // GET partida/stopPartida/5
        [HttpGet("stopPartida/{id}")]
        public void StopPartida(int id, [FromBody] Partida p)
        {
            UserService objUserService = new UserService();
            objUserService.StopPartida(p.Id);
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
