namespace Angular.Server.WebAPI.Controllers
{
    using System.Linq;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;

    using global::AutoMapper;
    using global::AutoMapper.QueryableExtensions;

    using Services.Abstractions;

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
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
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
