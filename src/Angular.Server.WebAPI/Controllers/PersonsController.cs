using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AutoMapper;
using AutoMapper.QueryableExtensions;

using Angular.Server.Models.DomainModels;
using Angular.Server.Services.Abstractions;
using Angular.Server.WebAPI.Models.Person;

namespace Angular.Server.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class PersonsController : Controller
    {
        private IPersonService personService;

        private readonly IMapper mapper;

        public PersonsController(IPersonService personService, IMapper mapper)
        {
            this.personService = personService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {

            var personsListModels = this.personService.All().ProjectTo<PersonListModel>().ToList();

            if (personsListModels == null)
            {
                return NotFound();
            }

            return Ok(personsListModels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var personDetailsModel = this.personService.All()
                .Where(p => p.Id == id)
                .ProjectTo<PersonDetailsModel>()
                .FirstOrDefault();

            if (personDetailsModel == null)
            {
                return NotFound();
            }

            return Ok(personDetailsModel);
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
