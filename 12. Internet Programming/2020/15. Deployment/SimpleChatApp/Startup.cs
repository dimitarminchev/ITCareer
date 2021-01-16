using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RestApi.Data;
using System;

namespace SimpleChatApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            if (string.IsNullOrEmpty(Environment.GetEnvironmentVariable("DATABASE_URL")))
                Environment.SetEnvironmentVariable("DATABASE_URL", "Data Source=app.db");
            services.AddDbContext<MessagesContext>(options =>
                options.UseSqlite(Environment.GetEnvironmentVariable("DATABASE_URL")));
            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
