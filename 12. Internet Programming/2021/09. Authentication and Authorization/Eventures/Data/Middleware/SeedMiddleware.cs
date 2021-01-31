using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Data
{
    public class SeedMiddleware
    {
        private readonly RequestDelegate next;

        private bool executed;

        public SeedMiddleware(RequestDelegate next)
        {
            this.next = next;
            this.executed = false;
        }

        public async Task InvokeAsync(HttpContext httpContext, ApplicationDbContext dbContext, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (!this.executed)
            {
                this.executed = true;

                // Is Database Created
                dbContext.Database.EnsureCreated();

                // Add Admin Role
                if (!await roleManager.RoleExistsAsync(GlobalConstants.AdminRoleName))
                {
                    await roleManager.CreateAsync(new IdentityRole(GlobalConstants.AdminRoleName));
                }

                // Add Admin User
                if (!userManager.Users.Any(u => u.UserName == "admin"))
                {
                    var user = new User
                    {
                        UserName = "admin",
                        Email = "admin@example.com",
                        FirstName = "admin",
                        LastName = "admin",
                        UniqueCitizenNumber = "0000000000"
                    };
                    await userManager.CreateAsync(user, "admin");
                    await userManager.AddToRoleAsync(user, GlobalConstants.AdminRoleName);
                }
            }

            await this.next(httpContext);
        }
    }
}
