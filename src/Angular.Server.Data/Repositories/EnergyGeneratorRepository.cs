using Angular.Server.Data.Repositories.Abstractions;
using Angular.Server.Models.DomainModels;

namespace Angular.Server.Data.Repositories
{
    public class EnergyGeneratorRepository : 
        AuditableEntityRepository<EnergyGenerator>, IEnergyGeneratorRepository
    {
        public EnergyGeneratorRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
