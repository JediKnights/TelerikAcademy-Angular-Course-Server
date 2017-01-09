using System;
using System.Linq;

using Angular.Server.Data.Repositories.Abstractions;
using Angular.Server.Models.DomainModels;
using Angular.Server.Services.Abstractions;

namespace Angular.Server.Services
{
    public class EnergyGeneratorService : IEnergyGeneratorService
    {
        private readonly IEnergyGeneratorRepository energyGeneratorRepository;

        public EnergyGeneratorService(IEnergyGeneratorRepository energyGeneratorRepository)
        {
            this.energyGeneratorRepository = energyGeneratorRepository;
        }

        public IQueryable<EnergyGenerator> All()
        {
            return this.energyGeneratorRepository.All();
        }

        public EnergyGenerator GetById(int id)
        {
            return this.energyGeneratorRepository.GetById(id);
        }

        public void Add(EnergyGenerator energyGenerator)
        {
            this.energyGeneratorRepository.Add(energyGenerator);
            this.energyGeneratorRepository.SaveChanges();
        }

        public void Update(EnergyGenerator energyGenerator)
        {
            this.energyGeneratorRepository.Update(energyGenerator);
            this.energyGeneratorRepository.SaveChanges();
        }

        public void Delete(EnergyGenerator energyGenerator)
        {
            this.energyGeneratorRepository.Delete(energyGenerator);
            this.energyGeneratorRepository.SaveChanges();
        }

        public void HardDelete(EnergyGenerator energyGenerator)
        {
            this.energyGeneratorRepository.HardDelete(energyGenerator);
            this.energyGeneratorRepository.SaveChanges();
        }
    }
}
