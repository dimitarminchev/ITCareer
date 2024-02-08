namespace it_kariera.mon.bg
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Builder
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            // App
            var app = builder.Build();
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();
            app.MapControllerRoute( name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

            // Run
            app.Run();
        }
    }
}
