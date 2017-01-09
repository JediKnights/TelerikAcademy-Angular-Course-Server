using Angular.Server.Data.Repositories.Abstractions;
using Angular.Server.Models.DomainModels;

namespace Angular.Server.Data.Repositories
{
    public class ElectricalDeviceConsumptionHistoryRepository : 
        GenericRepository<ElectricalDevicesConsumptionHistory>,
        IElectricalDeviceConsumptionHistoryRepository
    {
        public ElectricalDeviceConsumptionHistoryRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
