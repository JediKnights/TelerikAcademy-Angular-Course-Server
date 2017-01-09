using Angular.Server.Data.Repositories.Abstractions;
using Angular.Server.Models.DomainModels;

namespace Angular.Server.Data.Repositories
{
    public class ElectricalSystemRepository : 
        AuditableEntityRepository<ElectricalSystem>, IElectricalSystemRepository
    {
        public ElectricalSystemRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
