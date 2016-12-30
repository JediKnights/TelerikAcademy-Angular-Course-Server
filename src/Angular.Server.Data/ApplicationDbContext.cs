namespace Angular.Server.Data
{
    using System;
    using System.Linq;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    using Angular.Server.Models.DomainModels;
    using Angular.Server.Models.IdentityModels;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Unit> Units { get; set; }

        public DbSet<Person> Persons { get; set; }

        public override int SaveChanges()
        {
            this.ChangeTracker.DetectChanges();

            var entries = this.ChangeTracker.Entries<Unit>()
                .Where(e => e.State == EntityState.Added || e.State == EntityState.Modified);

            foreach (var entry in entries)
            {
                entry.Property("LastUpdatedOn").CurrentValue = DateTime.UtcNow;
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
