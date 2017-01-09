using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AutoMapper;
using AutoMapper.QueryableExtensions;

using Angular.Server.Models.DomainModels;
using Angular.Server.Services.Abstractions;
using Angular.Server.WebAPI.Models.ElectricalSystem;

namespace Angular.Server.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ElectricalSystemsController : Controller
    {
        private readonly IMapper mapper;

        private IElectricalSystemService electricalSystemService;

        public ElectricalSystemsController(IMapper mapper, IElectricalSystemService electricalSystemService)
        {
            this.electricalSystemService = electricalSystemService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var electricalSystemsListModels =
                this.electricalSystemService.All().ProjectTo<ElectricalSystemListModel>().ToList();

            if (electricalSystemsListModels == null)
            {
                return NotFound();
            }

            return Ok(electricalSystemsListModels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var electricalSystemDetailsModel = this.electricalSystemService.All()
                .Where(es => es.Id == id)
                .ProjectTo<ElectricalSystemDetailsModel>()
                .FirstOrDefault();

            if (electricalSystemDetailsModel == null)
            {
                return NotFound();
            }
                 
            return Ok(electricalSystemDetailsModel);
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
