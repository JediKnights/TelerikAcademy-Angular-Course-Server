using Angular.Server.Data.Repositories.Abstractions;
using Angular.Server.Models.DomainModels;

namespace Angular.Server.Data.Repositories
{
    public class ElectricalDeviceRepository : AuditableEntityRepository<ElectricalDevice>, IElectricalDeviceRepository
    {
        public ElectricalDeviceRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
