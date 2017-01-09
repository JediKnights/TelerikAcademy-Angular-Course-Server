using Angular.Server.Data.Repositories.Abstractions;
using Angular.Server.Models.DomainModels;

namespace Angular.Server.Data.Repositories
{
    public class BatteryPackRepository : AuditableEntityRepository<BatteryPack>, IBatteryPackRepository
    {
        public BatteryPackRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
