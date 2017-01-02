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
            var devicesModelsViewModels = 
                this.electricalDeviceModelService.All().ProjectTo<ElectricalDeviceModelViewModel>().ToList();

            if (devicesModelsViewModels == null)
            {
                return NotFound();
            }

            return Ok(devicesModelsViewModels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var electricalDeviceModel = this.electricalDeviceModelService.All().FirstOrDefault(ed => ed.Id == id);

            if (electricalDeviceModel == null)
            {
                return NotFound();
            }

            var electricalDeviceModelViewModel = mapper.Map<ElectricalDeviceModel, ElectricalDeviceModelViewModel>(electricalDeviceModel);

            return Ok(electricalDeviceModelViewModel);
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
