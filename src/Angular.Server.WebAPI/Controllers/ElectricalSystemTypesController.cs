using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AutoMapper;
using AutoMapper.QueryableExtensions;

using Angular.Server.Models.DomainModels;
using Angular.Server.Services.Abstractions;
using Angular.Server.WebAPI.Models.ElectricalSystemType;

namespace Angular.Server.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ElectricalSystemTypesController : Controller
    {
        private IElectricalSystemTypeService electricalSystemTypeService;

        private readonly IMapper mapper;

        public ElectricalSystemTypesController(IElectricalSystemTypeService electricalSystemTypeService, IMapper mapper)
        {
            this.electricalSystemTypeService = electricalSystemTypeService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var electricalSystemTypesListModels = 
                this.electricalSystemTypeService.All().ProjectTo<ElectricalSystemTypeListModel>().ToList();

            if (electricalSystemTypesListModels == null)
            {
                return NotFound();
            }

            return Ok(electricalSystemTypesListModels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var electricalSystemTypeDetailsModel = this.electricalSystemTypeService.All()
                .Where(est => est.Id == id)
                .ProjectTo<ElectricalSystemTypeDetailsModel>()
                .FirstOrDefault();

            if (electricalSystemTypeDetailsModel == null)
            {
                return NotFound();
            }

            return Ok(electricalSystemTypeDetailsModel);
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
