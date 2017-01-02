namespace Angular.Server.Data.Repositories
{
    using Angular.Server.Data.Repositories.Abstractions;
    using Angular.Server.Models.DomainModels;

    public class ElectricalSystemTypeRepository : 
        AuditableEntityRepository<ElectricalSystemType>, IElectricalSystemTypeRepository
    {
        public ElectricalSystemTypeRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
