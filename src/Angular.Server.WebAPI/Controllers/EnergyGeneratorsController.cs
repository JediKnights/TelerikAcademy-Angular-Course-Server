using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AutoMapper;
using AutoMapper.QueryableExtensions;

using Angular.Server.Models.DomainModels;
using Angular.Server.Services.Abstractions;
using Angular.Server.WebAPI.Models.EnergyGenerator;

namespace Angular.Server.WebAPI.Controllers
{
    

    [Route("api/[controller]")]
    public class EnergyGeneratorsController : Controller
    {
        private IEnergyGeneratorService energyGeneratorService;

        private readonly IMapper mapper;

        public EnergyGeneratorsController(
            IEnergyGeneratorService energyGeneratorService, IMapper mapper)
        {
            this.energyGeneratorService = energyGeneratorService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var energyGeneratorsListModels =
                this.energyGeneratorService.All().ProjectTo<EnergyGeneratorListModel>().ToList();

            if (energyGeneratorsListModels == null)
            {
                return NotFound();
            }

            return Ok(energyGeneratorsListModels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var energyGeneratorDetailsModel = this.energyGeneratorService.All()
                .Where(eg => eg.Id == id)
                .ProjectTo<EnergyGeneratorDetailsModel>()
                .FirstOrDefault();

            return new ObjectResult(energyGeneratorDetailsModel);
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
