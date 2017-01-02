namespace Angular.Server.Services
{
    using System;
    using System.Linq;

    using Angular.Server.Data.Repositories.Abstractions;
    using Angular.Server.Models.DomainModels;
    using Abstractions;

    public class ElectricalSystemService : IElectricalSystemService
    {
        private readonly IElectricalSystemRepository electricalSystemRepository;

        public ElectricalSystemService(IElectricalSystemRepository electricalSystemRepository)
        {
            this.electricalSystemRepository = electricalSystemRepository;
        }

        public IQueryable<ElectricalSystem> All()
        {
            return this.electricalSystemRepository.All();
        }

        public ElectricalSystem GetById(Guid id)
        {
            return this.electricalSystemRepository.GetById(id);
        }

        public void Add(ElectricalSystem electricalSystem)
        {
            this.electricalSystemRepository.Add(electricalSystem);
            this.electricalSystemRepository.SaveChanges();
        }

        public void Update(ElectricalSystem electricalSystem)
        {
            this.electricalSystemRepository.Update(electricalSystem);
            this.electricalSystemRepository.SaveChanges();
        }

        public void Delete(ElectricalSystem electricalSystem)
        {
            this.electricalSystemRepository.Delete(electricalSystem);
            this.electricalSystemRepository.SaveChanges();
        }

        public void HardDelete(ElectricalSystem electricalSystem)
        {
            this.electricalSystemRepository.HardDelete(electricalSystem);
            this.electricalSystemRepository.SaveChanges();
        }
    }
}
