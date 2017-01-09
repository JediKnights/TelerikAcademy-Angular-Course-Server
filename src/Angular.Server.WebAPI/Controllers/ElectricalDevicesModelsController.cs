using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AutoMapper;
using AutoMapper.QueryableExtensions;

using Angular.Server.Models.DomainModels;
using Angular.Server.Services.Abstractions;
using Angular.Server.WebAPI.Models.ElectricalDeviceModel;

namespace Angular.Server.WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ElectricalDevicesModelsController : Controller
    {
        private IElectricalDeviceModelService electricalDeviceModelService;

        private readonly IMapper mapper;

        public ElectricalDevicesModelsController(
            IElectricalDeviceModelService electricalDeviceModelService, IMapper mapper)
        {
            this.electricalDeviceModelService = electricalDeviceModelService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var devicesModelsListModels = 
                this.electricalDeviceModelService.All().ProjectTo<ElectricalDeviceModelListModel>().ToList();

            if (devicesModelsListModels == null)
            {
                return NotFound();
            }

            return Ok(devicesModelsListModels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var electricalDeviceDetailsModel = this.electricalDeviceModelService.All()
                .Where(ed => ed.Id == id)
                .ProjectTo<ElectricalDeviceModelDetailsModel>()
                .FirstOrDefault();

            if (electricalDeviceDetailsModel == null)
            {
                return NotFound();
            }

            return Ok(electricalDeviceDetailsModel);
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
