using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPlanner.Shared.Posts.Queries.AllPostsQuery
{
    public class PostForListVm
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime? ScheduledDate { get; set; }
        public bool IsDraft { get; set; }
        public DateTime? CreateDate { get; set; }
        public int StatusId { get; set; }
        public int Id { get; set; }
    }
}
