using Microsoft.AspNetCore.Builder;

namespace VaryenceInterview.SPA.Extensions.AppBuilder
{
    public static class UseCustomMvcRoutesExtensions
    {
        public static IApplicationBuilder UseCustomMvcRoutes(this IApplicationBuilder appBuilder) =>
            appBuilder.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });
    }
}