using System;
using System.Linq;

using Angular.Server.Data.Repositories.Abstractions;
using Angular.Server.Models.DomainModels;
using Angular.Server.Services.Abstractions;

namespace Angular.Server.Services
{
    public class ElectricalSystemTypeService : IElectricalSystemTypeService
    {
        private readonly IElectricalSystemTypeRepository electricalSystemTypeRepository;

        public ElectricalSystemTypeService(IElectricalSystemTypeRepository electricalSystemTypeRepository)
        {
            this.electricalSystemTypeRepository = electricalSystemTypeRepository;
        }

        public IQueryable<ElectricalSystemType> All()
        {
            return this.electricalSystemTypeRepository.All();
        }

        public ElectricalSystemType GetById(int id)
        {
            return this.electricalSystemTypeRepository.GetById(id);
        }

        public void Add(ElectricalSystemType electricalSystemType)
        {
            this.electricalSystemTypeRepository.Add(electricalSystemType);
            this.electricalSystemTypeRepository.SaveChanges();
        }

        public void Update(ElectricalSystemType electricalSystemType)
        {
            this.electricalSystemTypeRepository.Update(electricalSystemType);
            this.electricalSystemTypeRepository.SaveChanges();
        }

        public void Delete(ElectricalSystemType electricalSystemType)
        {
            this.electricalSystemTypeRepository.Delete(electricalSystemType);
            this.electricalSystemTypeRepository.SaveChanges();
        }

        public void HardDelete(ElectricalSystemType electricalSystemType)
        {
            this.electricalSystemTypeRepository.HardDelete(electricalSystemType);
            this.electricalSystemTypeRepository.SaveChanges();
        }
    }
}
