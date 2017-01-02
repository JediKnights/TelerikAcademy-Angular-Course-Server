namespace Angular.Server.Data.Repositories
{
    using Angular.Server.Data.Repositories.Abstractions;
    using Angular.Server.Models.DomainModels;

    public class EnergyGeneratorRepository : 
        AuditableEntityRepository<EnergyGenerator>, IEnergyGeneratorRepository
    {
        public EnergyGeneratorRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
