using SocialMediaPlanner.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPlanner.Domain.Entities
{
    public class Account : AuditableEntity
    {
        public string AccountName { get; set; } //Nazwę dla grupy na fb, albo nazwa profilu itp.
        public int AccountTypeId { get; set; }
        public AccountType AccountType { get; set; }
        public int PlatformId { get; set; }
        public Platform Platform { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}
