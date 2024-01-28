using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Builder
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<Models.TasksContext>(option =>
                    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

            // App
            var app = builder.Build();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.MapControllerRoute(
               name: "default",
               pattern: "{controller=Task}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
