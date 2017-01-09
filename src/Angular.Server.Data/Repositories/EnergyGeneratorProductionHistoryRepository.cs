using Angular.Server.Data.Repositories.Abstractions;
using Angular.Server.Models.DomainModels;

namespace Angular.Server.Data.Repositories
{
    public class EnergyGeneratorProductionHistoryRepository :
        GenericRepository<EnergyGeneratorProductionHistory>, IEnergyGeneratorProductionHistoryRepository
    {
        public EnergyGeneratorProductionHistoryRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
