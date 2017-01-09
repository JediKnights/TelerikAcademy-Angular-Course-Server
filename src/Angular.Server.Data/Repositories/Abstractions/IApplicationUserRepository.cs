using Angular.Server.Models.IdentityModels;

namespace Angular.Server.Data.Repositories.Abstractions
{
    public interface IApplicationUserRepository : IAuditableEntityRepository<ApplicationUser>
    {
        ApplicationDbContext Context { get; }
    }
}
