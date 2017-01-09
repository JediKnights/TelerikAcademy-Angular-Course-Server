using Angular.Server.Models.DomainModels;

namespace Angular.Server.Services.Abstractions
{
    public interface IElectricalDeviceModelService : IRepositoryService<ElectricalDeviceModel>
    {
        ElectricalDeviceModel GetById(int id);
    }
}
