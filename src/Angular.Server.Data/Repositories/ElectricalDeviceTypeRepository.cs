namespace Angular.Server.Data.Repositories
{
    using Abstractions;
    using Angular.Server.Models.DomainModels;

    public class ElectricalDeviceTypeRepository : 
        AuditableEntityRepository<ElectricalDeviceType>, IElectricalDeviceTypeRepository
    {
        public ElectricalDeviceTypeRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
