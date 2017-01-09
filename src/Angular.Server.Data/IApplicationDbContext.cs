using Microsoft.EntityFrameworkCore;
using Angular.Server.Models.IdentityModels;

namespace Angular.Server.Data
{
    public interface IApplicationDbContext
    {
        DbSet<ApplicationUser> Users { get; set; }

        int SaveChanges();

        DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
