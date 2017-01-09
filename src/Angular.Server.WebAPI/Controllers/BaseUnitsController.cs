using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AutoMapper;
using AutoMapper.QueryableExtensions;

using Angular.Server.Models.DomainModels;
using Angular.Server.Services.Abstractions;
using Angular.Server.WebAPI.Models.BaseUnit;

namespace Angular.Server.WebAPI.Controllers
{
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
            var baseUnitListModels = this.baseUnitService.All().ProjectTo<BaseUnitListModel>().ToList();

            if (baseUnitListModels == null)
            {
                return NotFound();
            }

            return Ok(baseUnitListModels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var baseUnitDetailsModel = this.baseUnitService.All()
                .Where(bu => bu.Id == id)
                .ProjectTo<BaseUnitDetailsModel>()
                .FirstOrDefault();

            if (baseUnitDetailsModel == null)
            {
                return NotFound();
            }

            return new ObjectResult(baseUnitDetailsModel);
        }


        [HttpPost]
        public IActionResult Post([FromBody]BaseUnitCreateModel baseUnitCreateModel)
        {
            if (baseUnitCreateModel == null)
            {
                return BadRequest();
            }

            var baseUnit = new BaseUnit();

            baseUnit = mapper.Map<BaseUnitCreateModel, BaseUnit>(baseUnitCreateModel);

            this.baseUnitService.Add(baseUnit);

            return CreatedAtAction("Post", new { id = baseUnit.Id }, baseUnit);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]BaseUnitEditModel baseUnitEditModel)
        {
            if (baseUnitEditModel == null || baseUnitEditModel.Id != id)
            {
                return BadRequest();
            }

            var baseUnit = this.baseUnitService.GetById(id);

            if (baseUnit == null)
            {
                return NotFound();
            }

            Mapper.Map(baseUnitEditModel, baseUnit);

            this.baseUnitService.Update(baseUnit);

            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var baseUnit = this.baseUnitService.GetById(id);

            if (baseUnit == null)
            {
                return NotFound();
            }

            this.baseUnitService.Delete(baseUnit);

            return new NoContentResult();
        }
    }
}
