using Angular.Server.Data.Repositories.Abstractions;
using Angular.Server.Models.DomainModels;

namespace Angular.Server.Data.Repositories
{
    public class BaseUnitRepository : AuditableEntityRepository<BaseUnit>, IBaseUnitRepository
    {
        public BaseUnitRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
