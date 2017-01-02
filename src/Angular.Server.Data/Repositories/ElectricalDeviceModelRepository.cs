namespace Angular.Server.Data.Repositories
{
    using Angular.Server.Data.Repositories.Abstractions;
    using Angular.Server.Models.DomainModels;

    public class ElectricalDeviceModelRepository : 
        AuditableEntityRepository<ElectricalDeviceModel>, IElectricalDeviceModelRepository
    {
        public ElectricalDeviceModelRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
