using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AutoMapper;
using AutoMapper.QueryableExtensions;

using Angular.Server.Models.DomainModels;
using Angular.Server.Services.Abstractions;
using Angular.Server.WebAPI.Models.ElectricalDevice;

namespace Angular.Server.WebAPI.Controllers
{
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
            var devicesListModels = this.electricalDeviceService.All().ProjectTo<ElectricalDeviceListModel>().ToList();

            if (devicesListModels == null)
            {
                return NotFound();
            }

            return Ok(devicesListModels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var electricalDeviceDetailsModel = this.electricalDeviceService.All()
                .Where(ed => ed.Id == id)
                .ProjectTo<ElectricalDeviceDetailsModel>()
                .FirstOrDefault();

            if (electricalDeviceDetailsModel == null)
            {
                return NotFound();
            }

            return Ok(electricalDeviceDetailsModel);
        }

        [HttpPost]
        public IActionResult Post([FromBody]ElectricalDeviceCreateModel electricalDeviceCreateModel)
        {
            if (electricalDeviceCreateModel == null)
            {
                return BadRequest();
            }

            var electricalDevice = new ElectricalDevice();

            electricalDevice = mapper.Map<ElectricalDeviceCreateModel, ElectricalDevice>(electricalDeviceCreateModel);

            this.electricalDeviceService.Add(electricalDevice);

            return CreatedAtAction("Post", new { id = electricalDevice.Id }, electricalDevice);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]ElectricalDeviceEditModel electricalDeviceEditModel)
        {
            if (electricalDeviceEditModel == null || electricalDeviceEditModel.Id != id)
            {
                return BadRequest();
            }

            var electricalDevice = this.electricalDeviceService.GetById(id);

            if (electricalDevice == null)
            {
                return NotFound();
            }

            Mapper.Map(electricalDeviceEditModel, electricalDevice);

            this.electricalDeviceService.Update(electricalDevice);

            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var electricalDevice = this.electricalDeviceService.GetById(id);

            if (electricalDevice == null)
            {
                return NotFound();
            }

            this.electricalDeviceService.Delete(electricalDevice);

            return new NoContentResult();
        }
    }
}
