using Angular.Server.Models.DomainModels;

namespace Angular.Server.Services.Abstractions
{
    public interface IElectricalDeviceTypeService : IRepositoryService<ElectricalDeviceType>
    {
        ElectricalDeviceType GetById(int id);
    }
}
