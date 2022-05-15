using SocialMediaPlanner.Shared.Posts.Commands;
using SocialMediaPlanner.Shared.Posts.Queries.AllPostsQuery;

namespace SocialMediaPlanner.Client.Brokers.API
{
    public partial interface IApiBroker
    {
        Task<List<PostForListVm>> GetAllPostsAsync();
        Task AddPostAsync(AddPostVM post);
    }
}
