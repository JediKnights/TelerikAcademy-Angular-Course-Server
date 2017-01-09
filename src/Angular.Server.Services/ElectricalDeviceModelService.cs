using System;
using System.Linq;

using Angular.Server.Data.Repositories.Abstractions;
using Angular.Server.Models.DomainModels;
using Angular.Server.Services.Abstractions;

namespace Angular.Server.Services
{
    public class ElectricalDeviceModelService : IElectricalDeviceModelService
    {
        private readonly IElectricalDeviceModelRepository electricalDeviceModelRepository;

        public ElectricalDeviceModelService(IElectricalDeviceModelRepository electricalDeviceModelRepository)
        {
            this.electricalDeviceModelRepository = electricalDeviceModelRepository;
        }

        public IQueryable<ElectricalDeviceModel> All()
        {
            return this.electricalDeviceModelRepository.All();
        }

        public ElectricalDeviceModel GetById(int id)
        {
            return this.electricalDeviceModelRepository.GetById(id);
        }

        public void Add(ElectricalDeviceModel electricalDeviceModel)
        {
            this.electricalDeviceModelRepository.Add(electricalDeviceModel);
            this.electricalDeviceModelRepository.SaveChanges();
        }

        public void Update(ElectricalDeviceModel electricalDeviceModel)
        {
            this.electricalDeviceModelRepository.Update(electricalDeviceModel);
            this.electricalDeviceModelRepository.SaveChanges();
        }

        public void Delete(ElectricalDeviceModel electricalDeviceModel)
        {
            this.electricalDeviceModelRepository.Delete(electricalDeviceModel);
            this.electricalDeviceModelRepository.SaveChanges();
        }

        public void HardDelete(ElectricalDeviceModel electricalDeviceModel)
        {
            this.electricalDeviceModelRepository.HardDelete(electricalDeviceModel);
            this.electricalDeviceModelRepository.SaveChanges();
        }
    }
}
