namespace Angular.Server.Data.Repositories
{
    using Angular.Server.Data.Repositories.Abstractions;
    using Angular.Server.Models.DomainModels;

    public class ElectricalSystemRepository : 
        AuditableEntityRepository<ElectricalSystem>, IElectricalSystemRepository
    {
        public ElectricalSystemRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
