using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace VaryenceInterview.SPA.Extensions.AppBuilder
{
    public static class UseExceptionHandlerExtensions
    {
        public static IApplicationBuilder UseExceptionHandler(this IApplicationBuilder app, IHostingEnvironment env) =>
            env.IsDevelopment()
                ? app.UseDeveloperExceptionPage()
                : app.UseExceptionHandler("/Error")
                     .UseHsts();
    }
}