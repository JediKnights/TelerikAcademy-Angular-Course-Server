using Angular.Server.Models.DomainModels;

namespace Angular.Server.Services.Abstractions
{
    public interface IEnergyGeneratorService : IRepositoryService<EnergyGenerator>
    {
        EnergyGenerator GetById(int id);
    }
}
