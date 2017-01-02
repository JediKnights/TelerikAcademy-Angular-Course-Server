namespace Angular.Server.Services
{
    using System;
    using System.Linq;

    using Angular.Server.Data.Repositories.Abstractions;
    using Angular.Server.Models.DomainModels;
    using Abstractions;

    public class ElectricalDeviceService : IElectricalDeviceService
    {
        private readonly IElectricalDeviceRepository electricalDeviceRepository;

        public ElectricalDeviceService(IElectricalDeviceRepository electricalDeviceRepository)
        {
            this.electricalDeviceRepository = electricalDeviceRepository;
        }

        public IQueryable<ElectricalDevice> All()
        {
            return this.electricalDeviceRepository.All();
        }

        public ElectricalDevice GetById(Guid id)
        {
            return this.electricalDeviceRepository.GetById(id);
        }

        public void Add(ElectricalDevice electricalDevice)
        {
            this.electricalDeviceRepository.Add(electricalDevice);
            this.electricalDeviceRepository.SaveChanges();
        }

        public void Update(ElectricalDevice electricalDevice)
        {
            this.electricalDeviceRepository.Update(electricalDevice);
            this.electricalDeviceRepository.SaveChanges();
        }

        public void Delete(ElectricalDevice electricalDevice)
        {
            this.electricalDeviceRepository.Delete(electricalDevice);
            this.electricalDeviceRepository.SaveChanges();
        }

        public void HardDelete(ElectricalDevice electricalDevice)
        {
            this.electricalDeviceRepository.HardDelete(electricalDevice);
            this.electricalDeviceRepository.SaveChanges();
        }
    }
}
