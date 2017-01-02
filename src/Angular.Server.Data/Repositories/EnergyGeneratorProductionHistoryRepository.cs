namespace Angular.Server.Data.Repositories
{
    using Angular.Server.Data.Repositories.Abstractions;
    using Angular.Server.Models.DomainModels;

    public class EnergyGeneratorProductionHistoryRepository :
        GenericRepository<EnergyGeneratorProductionHistory>, IEnergyGeneratorProductionHistoryRepository
    {
        public EnergyGeneratorProductionHistoryRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
