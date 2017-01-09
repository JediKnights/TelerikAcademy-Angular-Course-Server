using System.Linq;
using Microsoft.AspNetCore.Mvc;

using AutoMapper;
using AutoMapper.QueryableExtensions;

using Angular.Server.Services.Abstractions;
using Angular.Server.Models.DomainModels;
using Angular.Server.WebAPI.Models.BatteryPack;

namespace Angular.Server.WebAPI.Controllers
{
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
            var batteryPacksListModels = 
                this.batteryPackService.All().ProjectTo<BatteryPackListModel>().ToList();

            if (batteryPacksListModels == null)
            {
                return NotFound();
            }

            return Ok(batteryPacksListModels);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var batteryPackDetailsModel = this.batteryPackService.All()
                .Where(bp => bp.Id == id)
                .ProjectTo<BatteryPackDetailsModel>()
                .FirstOrDefault();

            if (batteryPackDetailsModel == null)
            {
                return NotFound();
            }

            return Ok(batteryPackDetailsModel);
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
