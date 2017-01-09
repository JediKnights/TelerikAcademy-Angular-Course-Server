using Angular.Server.Data.Repositories.Abstractions;
using Angular.Server.Models.DomainModels;

namespace Angular.Server.Data.Repositories
{
    public class ElectricalSystemTypeRepository : 
        AuditableEntityRepository<ElectricalSystemType>, IElectricalSystemTypeRepository
    {
        public ElectricalSystemTypeRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
