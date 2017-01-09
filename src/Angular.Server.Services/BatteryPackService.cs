using System;
using System.Linq;

using Angular.Server.Data.Repositories.Abstractions;
using Angular.Server.Models.DomainModels;
using Angular.Server.Services.Abstractions;

namespace Angular.Server.Services
{
    public class BatteryPackService : IBatteryPackService
    {
        private readonly IBatteryPackRepository batteryPackRepository;

        public BatteryPackService(IBatteryPackRepository batteryPackRepository)
        {
            this.batteryPackRepository = batteryPackRepository;
        }

        public IQueryable<BatteryPack> All()
        {
            return this.batteryPackRepository.All();
        }

        public BatteryPack GetById(int id)
        {
            return this.batteryPackRepository.GetById(id);
        }

        public void Add(BatteryPack batteryPack)
        {
            this.batteryPackRepository.Add(batteryPack);
            this.batteryPackRepository.SaveChanges();
        }

        public void Update(BatteryPack batteryPack)
        {
            this.batteryPackRepository.Update(batteryPack);
            this.batteryPackRepository.SaveChanges();
        }

        public void Delete(BatteryPack batteryPack)
        {
            this.batteryPackRepository.Delete(batteryPack);
            this.batteryPackRepository.SaveChanges();
        }

        public void HardDelete(BatteryPack batteryPack)
        {
            this.batteryPackRepository.HardDelete(batteryPack);
            this.batteryPackRepository.SaveChanges();
        }
    }
}
