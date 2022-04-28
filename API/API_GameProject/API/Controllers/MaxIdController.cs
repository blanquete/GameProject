using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using API.DAL.Model;
using API.DAL.Service;

using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/maxId")]
    [ApiController]
    public class MaxIdController : ControllerBase
    {
        // GET: maxId
        [HttpGet]
        public List<MaxId> GetAll()
        {
            UserService objUserService = new UserService();
            return objUserService.GetAllMaxId();
        }

        // GET maxId/5
        [HttpGet("{id}")]
        public MaxId Get(string id)
        {
            UserService objUserService = new UserService();
            return objUserService.GetMaxId(id);
        }

        // POST maxId
        [HttpPost]
        public void Post([FromBody] MaxId d)
        {
            UserService objUserService = new UserService();
            objUserService.AddMaxId(d);
        }

        // PUT maxId/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] MaxId d)
        {
            UserService objUserService = new UserService();
            objUserService.UpdateMaxId(d);
        }

        // DELETE maxId/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            UserService objUserService = new UserService();
            objUserService.DeleteMaxId(id);
        }
    }
}
