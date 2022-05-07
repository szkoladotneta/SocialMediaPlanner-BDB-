using Microsoft.EntityFrameworkCore;
using SocialMediaPlanner.Domain.Entities;

namespace SocialMediaPlanner.Application.Common.Interfaces
{
    public interface ISocialMediaPlannerDbContext
    {
        DbSet<Account> Accounts { get; set; }
        DbSet<Post> Posts { get; set; }
        DbSet<Platform> Platforms { get; set; }
        DbSet<AccountType> AccountTypes { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
