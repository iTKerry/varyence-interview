using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using VaryenceInterview.SPA.Extensions.AppBuilder;
using VaryenceInterview.SPA.Extensions.ServiceCollection;

namespace VaryenceInterview.SPA
{
    public class Startup
    {
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _environment;

        public Startup(IConfiguration configuration, IHostingEnvironment environment)
        {
            _configuration = configuration;
            _environment = environment;
        }

        public void ConfigureServices(IServiceCollection services) =>
            services.AddCustomMvc()
                    .AddRouteOptions()
                    .AddSpaStaticFiles(cfg => { cfg.RootPath = "ClientApp/build"; });
        
        public void Configure(IApplicationBuilder app)
        {
            app.UseExceptionHandler(_environment)
               .UseHttpsRedirection()
               .UseStaticFiles()
               .UseCustomSpa(_environment)
               .UseCustomMvcRoutes()
               .UseSpaStaticFiles();
        }
    }
}