namespace Angular.Server.WebAPI.Controllers
{
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;

    using global::AutoMapper;
    using global::AutoMapper.QueryableExtensions;
    using Services.Abstractions;
    using Angular.Server.WebAPI.Models;
    using Server.Models.DomainModels;

    [Route("api/[controller]")]
    public class ElectricalDevicesController : Controller
    {
        private IElectricalDeviceService electricalDeviceService;

        private readonly IMapper mapper;

        public ElectricalDevicesController(IElectricalDeviceService electricalDeviceService, IMapper mapper)
        {
            this.electricalDeviceService = electricalDeviceService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var devicesViewModels = this.electricalDeviceService.All().ProjectTo<ElectricalDeviceViewModel>().ToList();

            if (devicesViewModels == null)
            {
                return NotFound();
            }

            return Ok(devicesViewModels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var electricalDevice = this.electricalDeviceService.All().FirstOrDefault(ed => ed.Id == id);

            if (electricalDevice == null)
            {
                return NotFound();
            }

            var electricalDeviceViewModel = mapper.Map<ElectricalDevice, ElectricalDeviceViewModel>(electricalDevice);

            return Ok(electricalDeviceViewModel);
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
