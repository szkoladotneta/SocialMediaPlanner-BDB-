using SocialMediaPlanner.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPlanner.Domain.Entities
{
    public class Platform : AuditableEntity
    {
        public string PlatformName { get; set; } //Social Media Platform
        public string APIKey { get; set; }
        public string APISecret { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
