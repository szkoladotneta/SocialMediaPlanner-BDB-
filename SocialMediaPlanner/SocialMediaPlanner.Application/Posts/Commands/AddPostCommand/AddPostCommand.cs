using MediatR;
using SocialMediaPlanner.Application.Common.Interfaces;
using SocialMediaPlanner.Domain.Entities;
using SocialMediaPlanner.Shared.Posts.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPlanner.Application.Posts.Commands.AddPostCommand
{
    public class AddPostCommand : IRequest<int>
    {
        public AddPostVM Post { get; set; }
    }

    public class AddPostCommandHandler : IRequestHandler<AddPostCommand, int>
    {
        private readonly ISocialMediaPlannerDbContext context;

        public AddPostCommandHandler(ISocialMediaPlannerDbContext context)
        {
            this.context = context;
        }

        public async Task<int> Handle(AddPostCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var post = new Post()
                {
                    Body = request.Post.Body,
                    IsDraft = request.Post.IsDraft,
                    Title = request.Post.Title,
                    ScheduledDate = request.Post.ScheduledDate
                };
                context.Posts.Add(post);
                await context.SaveChangesAsync(cancellationToken);
                return post.Id;
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
