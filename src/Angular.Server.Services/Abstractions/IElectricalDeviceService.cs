using Angular.Server.Models.DomainModels;

namespace Angular.Server.Services.Abstractions
{
    public interface IElectricalDeviceService : IRepositoryService<ElectricalDevice>
    {
        ElectricalDevice GetById(int id);
    }
}
