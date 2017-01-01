namespace Angular.Server.WebAPI.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;

    using global::AutoMapper;
    using global::AutoMapper.QueryableExtensions;

    using Angular.Server.Data.Repositories.Abstractions;
    using Angular.Server.Models.DomainModels;
    using Angular.Server.WebAPI.Models;

    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private IPersonRepository personRepository;

        private readonly IMapper mapper;

        public UsersController(IMapper mapper, IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var personsModels = this.personRepository.All().ProjectTo<PersonModel>().ToList();

            if (personsModels == null)
            {
                return NotFound();
            }

            return Ok(personsModels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var currentPerson = this.personRepository.All().FirstOrDefault(person => person.Id == id);

            if (currentPerson == null)
            {
                return NotFound();
            }

            var personModel = mapper.Map<Person, PersonModel>(currentPerson);

            return Ok(personModel);
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
