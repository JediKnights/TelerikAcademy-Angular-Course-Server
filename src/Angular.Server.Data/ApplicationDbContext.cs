namespace Angular.Server.Data
{
    using System;
    using System.Linq;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Angular.Server.Models.DomainModels;
    using Angular.Server.Models.IdentityModels;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BaseUnit> BaseUnits { get; set; }

        public DbSet<Person> Persons { get; set; }

        public override int SaveChanges()
        {
            //this.ChangeTracker.DetectChanges();

            //var newEntries = this.ChangeTracker.Entries()
            //    .Where(e => e.State == EntityState.Added);


            //var modifiedEntries = this.ChangeTracker.Entries()
            //    .Where(e => e.State == EntityState.Modified);

            //foreach (var entry in newEntries)
            //{
            //    entry.Property("CreatedOn").CurrentValue = DateTime.UtcNow;
            //}

            //foreach (var entry in modifiedEntries)
            //{
            //    entry.Property("LastUpdatedOn").CurrentValue = DateTime.UtcNow;
            //}

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public new DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
