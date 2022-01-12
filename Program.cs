using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ReportPublisher.Interface;
using ReportPublisher.Service;
using ReportPublisher.Service.Mock;
using System.Threading.Tasks;

// ReSharper disable All

namespace ReportPublisher
{
    internal static class Program
    {
        private static async Task Main(string[] args)
        {
            await Host.CreateDefaultBuilder(args)
                 .ConfigureServices(ConfigureServices)
                 .Build()
                 .Services
                 .GetService<MainService>()
                 .Execute();
        }

        private static void ConfigureServices(HostBuilderContext _, IServiceCollection services) =>
            services
                .AddSingleton<MainService>()
                .AddSingleton<IReportDeliveryService, ReportDeliveryService>()
                .AddTransient<IPackageConfigReader, MockPackageConfigReader>()
                .AddTransient<IFileSender, MockFileSender>()
                .AddTransient<IClientRepository, MockClientRepo>()
            ;
    }
}