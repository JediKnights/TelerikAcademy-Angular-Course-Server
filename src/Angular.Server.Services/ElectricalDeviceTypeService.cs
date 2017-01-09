using System;
using System.Linq;

using Angular.Server.Data.Repositories.Abstractions;
using Angular.Server.Models.DomainModels;
using Angular.Server.Services.Abstractions;

namespace Angular.Server.Services
{
    public class ElectricalDeviceTypeService : IElectricalDeviceTypeService
    {
        private readonly IElectricalDeviceTypeRepository electricalDeviceTypeRepository;

        public ElectricalDeviceTypeService(IElectricalDeviceTypeRepository electricalDeviceTypeRepository)
        {
            this.electricalDeviceTypeRepository = electricalDeviceTypeRepository;
        }

        public IQueryable<ElectricalDeviceType> All()
        {
            return this.electricalDeviceTypeRepository.All();
        }

        public ElectricalDeviceType GetById(int id)
        {
            return this.electricalDeviceTypeRepository.GetById(id);
        }

        public void Add(ElectricalDeviceType electricalDeviceType)
        {
            this.electricalDeviceTypeRepository.Add(electricalDeviceType);
            this.electricalDeviceTypeRepository.SaveChanges();
        }

        public void Update(ElectricalDeviceType electricalDeviceType)
        {
            this.electricalDeviceTypeRepository.Update(electricalDeviceType);
            this.electricalDeviceTypeRepository.SaveChanges();
        }

        public void Delete(ElectricalDeviceType electricalDeviceType)
        {
            this.electricalDeviceTypeRepository.Delete(electricalDeviceType);
            this.electricalDeviceTypeRepository.SaveChanges();
        }

        public void HardDelete(ElectricalDeviceType electricalDeviceType)
        {
            this.electricalDeviceTypeRepository.HardDelete(electricalDeviceType);
            this.electricalDeviceTypeRepository.SaveChanges();
        }
    }
}
