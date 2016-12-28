namespace Angular.Server.WebAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using Angular.Server.WebAPI.Models;

    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        // GET api/users
        [HttpGet]
        public IActionResult Get()
        {
            var users = SampleData.LoadUsers();

            if (users == null)
            {
                return NotFound();
            }

            return Ok(users);
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var currentUser = SampleData.LoadUsers().FirstOrDefault(user => user.Id == id);

            if (currentUser == null)
            {
                return NotFound();
            }

            return Ok(currentUser);
        }

        // POST api/users
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
