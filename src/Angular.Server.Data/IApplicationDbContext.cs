namespace Angular.Server.Data
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using Angular.Server.Models.IdentityModels;

    public interface IApplicationDbContext
    {
        DbSet<ApplicationUser> Users { get; set; }

        int SaveChanges();

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
