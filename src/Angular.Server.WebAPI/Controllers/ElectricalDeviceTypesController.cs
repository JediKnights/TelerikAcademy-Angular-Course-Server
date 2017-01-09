using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AutoMapper;
using AutoMapper.QueryableExtensions;

using Angular.Server.Models.DomainModels;
using Angular.Server.Services.Abstractions;
using Angular.Server.WebAPI.Models.ElectricalDeviceType;

namespace Angular.Server.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ElectricalDeviceTypesController : Controller
    {
        private IElectricalDeviceTypeService electricalDeviceTypeService;

        private readonly IMapper mapper;

        public ElectricalDeviceTypesController(IElectricalDeviceTypeService electricalDeviceTypeService, IMapper mapper)
        {
            this.electricalDeviceTypeService = electricalDeviceTypeService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var electricalDeviceTypesListModes =
                this.electricalDeviceTypeService.All().ProjectTo<ElectricalDeviceTypeListModel>().ToList();

            if (electricalDeviceTypesListModes == null)
            {
                return NotFound();
            }

            return Ok(electricalDeviceTypesListModes);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var electricalDeviceTypeDetailsModel = this.electricalDeviceTypeService.All()
                .Where(edt => edt.Id == id)
                .ProjectTo<ElectricalDeviceTypeDetailsModel>()
                .FirstOrDefault();

            if (electricalDeviceTypeDetailsModel == null)
            {
                return NotFound();
            }

            return Ok(electricalDeviceTypeDetailsModel);
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
