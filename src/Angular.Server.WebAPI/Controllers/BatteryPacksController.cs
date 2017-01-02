namespace Angular.Server.WebAPI.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;

    using global::AutoMapper;
    using global::AutoMapper.QueryableExtensions;

    using Services.Abstractions;
    using Models;
    using Server.Models.DomainModels;

    [Route("api/[controller]")]
    public class BatteryPacksController : Controller
    {
        private IBatteryPackService batteryPackService;

        private readonly IMapper mapper;

        public BatteryPacksController(IBatteryPackService batteryPackService, IMapper mapper)
        {
            this.batteryPackService = batteryPackService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var batteryPacksViewModels = 
                this.batteryPackService.All().ProjectTo<BatteryPackViewModel>().ToList();

            if (batteryPacksViewModels == null)
            {
                return NotFound();
            }

            return Ok(batteryPacksViewModels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var batteryPack = this.batteryPackService.All().FirstOrDefault(bps => bps.Id == id);

            if (batteryPack == null)
            {
                return NotFound();
            }

            var batteryPackViewModel = mapper.Map<BatteryPack, BatteryPackViewModel>(batteryPack);

            return Ok(batteryPackViewModel);
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
