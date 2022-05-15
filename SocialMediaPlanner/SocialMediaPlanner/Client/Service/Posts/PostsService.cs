using Microsoft.IdentityModel.SecurityTokenService;
using SocialMediaPlanner.Client.Brokers.API;
using SocialMediaPlanner.Shared.Posts.Commands;
using SocialMediaPlanner.Shared.Posts.Exceptions;
using SocialMediaPlanner.Shared.Posts.Queries.AllPostsQuery;

namespace SocialMediaPlanner.Client.Service.Posts
{
    public partial class PostsService : IPostsService
    {
        private readonly IApiBroker apiBroker;

        public PostsService(IApiBroker apiBroker)
        {
            this.apiBroker = apiBroker;
        }

        public async Task<List<PostForListVm>> GetAllPostsAsync()
        {
            
            return await apiBroker.GetAllPostsAsync();

        }

        public async Task AddPostAsync(AddPostVM post)
        {
            ValidatePost(post);

            try
            {
                await apiBroker.AddPostAsync(post);
            }
            catch (BadRequestException ex)
            {

                throw new PostBadRequestException(ex);
            }
        }

    }
}
