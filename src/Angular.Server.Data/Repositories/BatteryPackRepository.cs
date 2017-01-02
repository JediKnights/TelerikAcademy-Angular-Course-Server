namespace Angular.Server.Data.Repositories
{
    using Angular.Server.Data.Repositories.Abstractions;
    using Angular.Server.Models.DomainModels;

    public class BatteryPackRepository : AuditableEntityRepository<BatteryPack>, IBatteryPackRepository
    {
        public BatteryPackRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
