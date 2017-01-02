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

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
