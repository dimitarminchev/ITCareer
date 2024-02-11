namespace ChatUi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // builder
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            // App
            var app = builder.Build();
            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            // Run
            app.Run();
        }
    }
}
