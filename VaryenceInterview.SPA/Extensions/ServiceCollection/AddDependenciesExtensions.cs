using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VaryenceInterview.Configuration;
using VaryenceInterview.Infrastructure.Http;
using VaryenceInterview.Infrastructure.Repositories;
using VaryenceInterview.Services;

namespace VaryenceInterview.SPA.Extensions.ServiceCollection
{
    public static class AddDependenciesExtensions
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration cfg) =>
            services.AddTransient<IHttpFetcher, HttpFetcher>()
                    .AddTransient<IGeocodingRepository>(provider =>
                        new GeocodingRepository(cfg[ConfigurationPaths.GoogleMapsApiKey],
                        provider.GetService<IHttpFetcher>()))
                    .AddTransient<IGeolocationService, GeolocationService>();
    }
}