using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialMediaPlanner.Application.Common.Interfaces;
using SocialMediaPlanner.Application.Common.Models;

namespace SocialMediaPlanner.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SocialMediaPlannerDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("SocialMediaPlannerDatabase")));

            services.AddIdentityCore<ApiUser>()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<SocialMediaPlannerDbContext>();
            services.AddScoped<ISocialMediaPlannerDbContext, SocialMediaPlannerDbContext>();
            return services;
        }
    }
}
