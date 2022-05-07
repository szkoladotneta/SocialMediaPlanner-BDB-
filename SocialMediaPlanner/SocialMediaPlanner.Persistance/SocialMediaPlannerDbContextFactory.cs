using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPlanner.Persistance
{
    public class SocialMediaPlannerDbContextFactory : DesignTimeDbContextFactoryBase<SocialMediaPlannerDbContext>
    {
        protected override SocialMediaPlannerDbContext CreateNewInstance(DbContextOptions<SocialMediaPlannerDbContext> options)
        {
            return new SocialMediaPlannerDbContext(options);
        }
    }
}
