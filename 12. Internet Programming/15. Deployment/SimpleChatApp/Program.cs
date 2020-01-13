using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace SimpleChatApp
{
    public static class Program
    {
        public static void Main(string[] args) =>
            CreateHostBuilder(args).Build().Run();

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>().UseKestrel((context, options) =>
                    {
                        var port = Environment.GetEnvironmentVariable("PORT");
                        if (!string.IsNullOrEmpty(port))
                            options.ListenAnyIP(int.Parse(port));
                    });
                });
    }
}
