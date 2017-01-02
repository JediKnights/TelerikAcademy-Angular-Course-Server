namespace Angular.Server.WebAPI.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;

    using global::AutoMapper;
    using global::AutoMapper.QueryableExtensions;

    using Services.Abstractions;
    using Models;
    using Server.Models.DomainModels;

    [Route("api/[controller]")]
    public class BaseUnitsController : Controller
    {
        private IBaseUnitService baseUnitService;

        private readonly IMapper mapper;

        public BaseUnitsController(IBaseUnitService baseUnitService, IMapper mapper)
        {
            this.baseUnitService = baseUnitService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var baseUnitViewModels = this.baseUnitService.All().ProjectTo<BaseUnitViewModel>().ToList();

            if (baseUnitViewModels == null)
            {
                return NotFound();
            }

            return Ok(baseUnitViewModels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var baseUnit = this.baseUnitService.All().FirstOrDefault(b => b.Id == id);

            if (baseUnit == null)
            {
                return NotFound();
            }

            var baseUnitViewModels = mapper.Map<BaseUnit, BaseUnitViewModel>(baseUnit);

            return Ok(baseUnitViewModels);
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
