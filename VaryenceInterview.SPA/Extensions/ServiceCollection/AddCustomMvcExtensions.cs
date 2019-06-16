using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using VaryenceInterview.SPA.Extensions.MvcBuilder;
using VaryenceInterview.SPA.Filters;

namespace VaryenceInterview.SPA.Extensions.ServiceCollection
{
    public static class AddCustomMvcExtensions
    {
        public static IServiceCollection AddCustomMvc(this IServiceCollection services) =>
            services.AddMvc(options =>
                {
                    options.Filters.Add(typeof(ValidateModelStateAttribute));
                })
                .AddCustomJsonOptions()
                .SetCompatibilityVersion(CompatibilityVersion.Latest)
                .Services;
    }
}