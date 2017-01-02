namespace Angular.Server.Data.Repositories
{
    using Angular.Server.Data.Repositories.Abstractions;
    using Angular.Server.Models.DomainModels;

    public class ElectricalDeviceRepository : AuditableEntityRepository<ElectricalDevice>, IElectricalDeviceRepository
    {
        public ElectricalDeviceRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
