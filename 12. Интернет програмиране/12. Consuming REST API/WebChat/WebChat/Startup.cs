using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Linq;
using WebChat.Data;

namespace WebChat
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<MessagesContext>(options => options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WebChatDb"));
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Database
            var dbContext = new MessagesContext();
            dbContext.Database.EnsureCreated();
            if (!dbContext.Messages.Any())
            {
                dbContext.Messages.Add
                (
                    new Model.Message
                    {
                        User = "Pesho",
                        Content = "Hello!"
                    }
                );
            }
            dbContext.SaveChanges();

            // Exceptions in Development
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseRouting();

            // Routes
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
