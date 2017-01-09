using Angular.Server.Models.DomainModels;

namespace Angular.Server.Services.Abstractions
{
    public interface IElectricalSystemTypeService : IRepositoryService<ElectricalSystemType>
    {
        ElectricalSystemType GetById(int id);
    }
}
