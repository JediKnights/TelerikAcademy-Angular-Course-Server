namespace Angular.Server.WebAPI.DependencyInjection
{
    using Data;
    using Data.Repositories;
    using Data.Repositories.Abstractions;
    using Microsoft.Extensions.DependencyInjection;
    using Services;
    using Services.Abstractions;

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services, string dependencyInjectorName)
        {
            if (dependencyInjectorName == "BuiltInDependencyInjector")
            {
                BindRepositories(services);
                BindServicesFromServiceProject(services);
            }

            return services;
        }

        public static void BindRepositories(IServiceCollection services)
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

        public static void BindServicesFromServiceProject(IServiceCollection services)
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
