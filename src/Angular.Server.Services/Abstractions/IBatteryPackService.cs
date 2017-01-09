using Angular.Server.Models.DomainModels;

namespace Angular.Server.Services.Abstractions
{
    public interface IBatteryPackService : IRepositoryService<BatteryPack>
    {
        BatteryPack GetById(int id);
    }
}
