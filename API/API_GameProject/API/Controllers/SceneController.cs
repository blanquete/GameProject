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
    [Route("api/scene")]
    [ApiController]
    public class SceneController : ControllerBase
    {
        // GET: scene
        [HttpGet]
        public List<Scene> GetAll()
        {
            UserService objUserService = new UserService();
            return objUserService.GetAllScene();
        }

        // GET scene/5
        [HttpGet("{id}")]
        public Scene Get(int id)
        {
            UserService objUserService = new UserService();
            return objUserService.GetScene(id);
        }

        // POST scene
        [HttpPost]
        public void Post([FromBody] Scene s)
        {
            UserService objUserService = new UserService();

            objUserService.AddScene(s);
        }

        // PUT scene/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Scene s)
        {
            UserService objUserService = new UserService();
            objUserService.UpdateScene(s);
        }

        // DELETE scene/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            UserService objUserService = new UserService();
            objUserService.DeleteScene(id);
        }
    }
}
