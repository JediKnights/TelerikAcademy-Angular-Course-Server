using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Angular.Server.Models.DomainModels;
using Angular.Server.Models.IdentityModels;

namespace Angular.Server.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<BaseUnit> BaseUnits { get; set; }

        public DbSet<ElectricalDevice> ElectricalDevices { get; set; }

        public DbSet<ElectricalDeviceModel> ElectricalDeviceModels { get; set; }

        public DbSet<ElectricalDeviceType> ElectricalDeviceTypes { get; set; }

        public DbSet<ElectricalDevicesConsumptionHistory> ElectricalDevicesConsumptionHistories { get; set; }

        public DbSet<ElectricalSystem> ElectricalSystems { get; set; }

        public DbSet<ElectricalSystemType> ElectricalSystemTypes { get; set; }

        public DbSet<EnergyGenerator> EnergyGenerators { get; set; }

        public DbSet<EnergyGeneratorProductionHistory> EnergyGeneratorProductionHistories { get; set; }

        public DbSet<BatteryPack> BatteryPacks { get; set; }

        public DbSet<BatteryPackChargeHistory> BatteryPackChargeHistories { get; set; }

        public DbSet<Manufacturer> Manufacturers { get; set; }

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
