using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FDMC.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FDMC
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
            services.AddDbContext<CatContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
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

        // Ensure the database is created and adds two records.
        private static void UpdateDatabase(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                using (var context = serviceScope.ServiceProvider.GetService<CatContext>())
                {
                    context.Database.EnsureCreated();
                    if (!context.Cats.Any())
                    {
                        context.Cats.Add(new Cat { Name = "Tom", Age = 5, Breed = "Black", ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/23/Close_up_of_a_black_domestic_cat.jpg/1200px-Close_up_of_a_black_domestic_cat.jpg" });
                        context.Cats.Add(new Cat { Name = "Mary", Age = 7, Breed = "Gray", ImageUrl = "http://4.bp.blogspot.com/-ABNCNaeAWmU/VqkYRjTnbPI/AAAAAAABj_A/ef8aRYwWiJU/s1600/funny-cats-191-02.jpg" });
                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
