using Microsoft.AspNetCore.Builder;

namespace Eventures.Data
{
    public static class MiddlewareExtensions
    {
        public static IApplicationBuilder UseSeedMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SeedMiddleware>();
        }
    }
}
