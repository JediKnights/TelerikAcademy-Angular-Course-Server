namespace Angular.Server.WebAPI.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;

    using Angular.Server.Data;

    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private ApplicationDbContext context;

        public UsersController(ApplicationDbContext context)
        {
            this.context = context;
        }

        // GET api/users
        [HttpGet]
        public IActionResult Get()
        {

            var persons = context.Persons.Select(
                person => new
                {
                    Id = person.Id,
                    Name = person.FirstName + " " + person.LastName
                });

            if (persons == null)
            {
                return NotFound();
            }

            return Ok(persons);
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var currentPerson = context
                .Persons
                .Select(person => new
                {
                    Id = person.Id,
                    Name = person.FirstName + " " + person.LastName
                })
                .FirstOrDefault(person => person.Id == id);
                

            if (currentPerson == null)
            {
                return NotFound();
            }

            return Ok(currentPerson);
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
