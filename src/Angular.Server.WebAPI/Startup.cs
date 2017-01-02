namespace Angular.Server.WebAPI
{
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;

    using global::AutoMapper;

    using Angular.Server.Data;
    using Angular.Server.Data.Repositories;
    using Angular.Server.Data.Repositories.Abstractions;
    using Angular.Server.Models.IdentityModels;
    using Angular.Server.WebAPI.Seed;
    using Services.Abstractions;
    using Services;

    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();

            builder.AddEnvironmentVariables();

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddCors();

            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            this.BindRepositories(services);

            this.BindServicesFromServiceProject(services);

            services.AddMvc();

            services.AddAutoMapper();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            if (env.IsDevelopment())
            {
                using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
                {

                    serviceScope.ServiceProvider.GetService<ApplicationDbContext>().Database.Migrate();

                    DatabaseInitializer.SeedData(app.ApplicationServices).Wait();
                }
            }

            app.UseIdentity();

            app.UseCors(builder => builder.WithOrigins("http://localhost:4200"));

            app.UseMvc();
        }

        public void BindRepositories(IServiceCollection services)
        {
            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();

            services.AddScoped<IBaseUnitRepository, BaseUnitRepository>();

            services.AddScoped<IBatteryPackRepository, BatteryPackRepository>();

            services.AddScoped<IElectricalDeviceConsumptionHistoryRepository,
                ElectricalDeviceConsumptionHistoryRepository>();

            services.AddScoped<IElectricalDeviceRepository, ElectricalDeviceRepository>();

            services.AddScoped<IElectricalDeviceTypeRepository, ElectricalDeviceTypeRepository>();

            services.AddScoped<IElectricalSystemRepository, ElectricalSystemRepository>();

            services.AddScoped<IElectricalSystemTypeRepository, ElectricalSystemTypeRepository>();

            services.AddScoped<IEnergyGeneratorProductionHistoryRepository,
                EnergyGeneratorProductionHistoryRepository>();

            services.AddScoped<IEnergyGeneratorRepository, EnergyGeneratorRepository>();

            services.AddScoped<IPersonRepository, PersonRepository>();

            services.AddScoped<IBaseUnitService, BaseUnitService>();

            services.AddScoped<IBatteryPackService, BatteryPackService>();

            services.AddScoped<IElectricalDeviceService, ElectricalDeviceService>();

            services.AddScoped<IElectricalDeviceModelRepository, ElectricalDeviceModelRepository>();

            services.AddScoped<IElectricalSystemService, ElectricalSystemService>();

            services.AddScoped<IEnergyGeneratorService, EnergyGeneratorService>();

            services.AddScoped<IPersonService, PersonService>();
        }

        public void BindServicesFromServiceProject(IServiceCollection services)
        {
            services.AddScoped<IBaseUnitService, BaseUnitService>();

            services.AddScoped<IBatteryPackService, BatteryPackService>();

            services.AddScoped<IElectricalDeviceService, ElectricalDeviceService>();

            services.AddScoped<IElectricalDeviceModelService, ElectricalDeviceModelService>();

            services.AddScoped<IElectricalSystemService, ElectricalSystemService>();

            services.AddScoped<IEnergyGeneratorService, EnergyGeneratorService>();

            services.AddScoped<IPersonService, PersonService>();
        }
    }
}
