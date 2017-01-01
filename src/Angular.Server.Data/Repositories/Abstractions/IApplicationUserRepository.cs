namespace Angular.Server.Data.Repositories.Abstractions
{
    using Angular.Server.Models.IdentityModels;

    public interface IApplicationUserRepository : IAuditableEntityRepository<ApplicationUser>
    {
        ApplicationDbContext Context { get; }
    }
}
