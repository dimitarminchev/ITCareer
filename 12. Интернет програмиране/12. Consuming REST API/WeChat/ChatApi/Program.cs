
using ChatApi.Model;
using Microsoft.EntityFrameworkCore;

namespace ChatApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Builder
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Database 
            builder.Services.AddDbContext<MessagesContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
            );

            // cors
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .WithExposedHeaders("content-disposition")
                    .AllowAnyHeader();
                });
            });


            // App
            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.UseCors();

            // Run
            app.Run();
        }
    }
}
