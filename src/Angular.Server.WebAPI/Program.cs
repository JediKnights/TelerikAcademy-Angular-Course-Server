namespace Angular.Server.WebAPI
{
    using System.IO;
    using Microsoft.AspNetCore.Hosting;
    using System.Collections.Generic;
    using Microsoft.Extensions.Configuration;

    public class Program
    {
        private static readonly Dictionary<string, string> defaults =
            new Dictionary<string, string>
            {
                { WebHostDefaults.EnvironmentKey, "Development" }
            };

        public static void Main(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("hosting.json", optional: true)
                .AddInMemoryCollection(defaults)
                .AddEnvironmentVariables("ASPNETCORE_ENVIRONMENT")
                .AddCommandLine(args)
                .Build();

            var host = new WebHostBuilder()
                .UseConfiguration(configuration)
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseKestrel()
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}