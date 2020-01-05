using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CHUSHKA.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CHUSHKA
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddDbContext<ChushkaContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

            UpdateDatabase(app);
        }

        // Ensure the database is created
        private static void UpdateDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<ChushkaContext>())
                {
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();
                    // Fill the Datadase
                    if (!context.Users.Any())
                    {
                        context.Users.Add(new User { Username = "mitko", Password = "mitko", FullName = "Dimitar Minchev", Email = "mitko@bfu.bg", Role = 0 });
                        context.Users.Add(new User { Username = "ivan", Password = "ivan", FullName = "Ivan Ivanov", Email = "ivan@abv.bg", Role = 0 });
                        context.SaveChanges();
                    }
                    if (!context.Products.Any())
                    {
                        context.Products.Add(new Product { Name = "Beer", Price = 2, Description = "Beer", Type = 0 });
                        context.Products.Add(new Product { Name = "Fries", Price = 1, Description = "Fries", Type = 0 });
                        context.SaveChanges();
                    }
                    if (!context.Orders.Any())
                    {
                        context.Orders.Add(new Order { ProductId = 1, UserId = 1, OrderedOn = new DateTime() });
                        context.Orders.Add(new Order { ProductId = 2, UserId = 1, OrderedOn = new DateTime() });
                        context.Orders.Add(new Order { ProductId = 1, UserId = 2, OrderedOn = new DateTime() });
                        context.Orders.Add(new Order { ProductId = 2, UserId = 2, OrderedOn = new DateTime() });
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
