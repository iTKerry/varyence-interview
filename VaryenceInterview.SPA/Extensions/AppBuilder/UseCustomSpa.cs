using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;

namespace VaryenceInterview.SPA.Extensions.AppBuilder
{
    public static class UseCustomSpaExtensions
    {
        public static IApplicationBuilder UseCustomSpa(this IApplicationBuilder appBuilder, IHostingEnvironment env)
        {
            appBuilder.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
            return appBuilder;
        }
    }
}