using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VaryenceInterview.Configuration;
using VaryenceInterview.Infrastructure;
using VaryenceInterview.Services;

namespace VaryenceInterview.SPA.Extensions.ServiceCollection
{
    public static class AddDependenciesExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration cfg) =>
            services.AddTransient<IGeocodingRepository>(provider => new GeocodingRepository(cfg[ConfigurationPaths.GoogleMapsApiKey]))
                    .AddTransient<IGeolocationService, GeolocationService>();
    }
}