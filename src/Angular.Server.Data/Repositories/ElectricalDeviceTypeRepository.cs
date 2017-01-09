using Angular.Server.Data.Repositories.Abstractions;
using Angular.Server.Models.DomainModels;

namespace Angular.Server.Data.Repositories
{
    public class ElectricalDeviceTypeRepository : 
        AuditableEntityRepository<ElectricalDeviceType>, IElectricalDeviceTypeRepository
    {
        public ElectricalDeviceTypeRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
