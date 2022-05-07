using SocialMediaPlanner.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPlanner.Domain.Entities
{
    public class Post : AuditableEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime? ScheduledDate { get; set; }
        public bool IsDraft { get; set; }
        public ICollection<Account> Accounts { get; set; }
    }
}
