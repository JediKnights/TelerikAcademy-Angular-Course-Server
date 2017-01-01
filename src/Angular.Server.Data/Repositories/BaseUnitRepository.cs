namespace Angular.Server.Data.Repositories
{
    using Angular.Server.Data.Repositories.Abstractions;
    using Angular.Server.Models.DomainModels;

    public class BaseUnitRepository : AuditableEntityRepository<BaseUnit>, IBaseUnitRepository
    {
        public BaseUnitRepository(IApplicationDbContext context) : base(context)
        {
        }
    }
}
