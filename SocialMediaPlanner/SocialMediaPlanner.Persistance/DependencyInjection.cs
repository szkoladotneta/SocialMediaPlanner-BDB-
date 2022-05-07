using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialMediaPlanner.Application.Common.Interfaces;

namespace SocialMediaPlanner.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SocialMediaPlannerDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("SocialMediaPlannerDatabase")));

            services.AddScoped<ISocialMediaPlannerDbContext, SocialMediaPlannerDbContext>();
            return services;
        }
    }
}
