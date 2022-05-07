using MediatR;
using Microsoft.EntityFrameworkCore;
using SocialMediaPlanner.Application.Common.Interfaces;
using SocialMediaPlanner.Domain.Entities;
using SocialMediaPlanner.Shared.Posts.Queries.AllPostsQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPlanner.Application.Posts.Queries.AllPostsQuery
{
    public class AllPostsQuery : IRequest<List<PostForListVm>>
    {
    }

    public class AllPostsQueryHandler : IRequestHandler<AllPostsQuery, List<PostForListVm>>
    {
        public readonly ISocialMediaPlannerDbContext _context;
        public AllPostsQueryHandler(ISocialMediaPlannerDbContext context)
        {
            _context = context;
        }
        public async Task<List<PostForListVm>> Handle(AllPostsQuery request, CancellationToken cancellationToken)
        {
            var posts = await _context.Posts.ToListAsync();
            return MapPostsToVm(posts);
        }

        private List<PostForListVm> MapPostsToVm(List<Post> posts)
        {
            var result = new List<PostForListVm>();
            foreach (var post in posts)
            {
                var postVm = new PostForListVm()
                {
                    Body = post.Body,
                    IsDraft = post.IsDraft,
                    ScheduledDate = post.ScheduledDate,
                    Title = post.Title,
                    CreateDate = post.Created,
                    StatusId = post.StatusId,
                    Id = post.Id,
                };
                result.Add(postVm);
            }
            return result;
        }
    }
}
