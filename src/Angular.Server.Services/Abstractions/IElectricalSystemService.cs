using Angular.Server.Models.DomainModels;

namespace Angular.Server.Services.Abstractions
{
    public interface IElectricalSystemService : IRepositoryService<ElectricalSystem>
    {
        ElectricalSystem GetById(int id);
    }
}
