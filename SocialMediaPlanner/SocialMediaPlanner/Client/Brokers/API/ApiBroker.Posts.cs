using SocialMediaPlanner.Shared.Posts.Commands;
using SocialMediaPlanner.Shared.Posts.Queries.AllPostsQuery;

namespace SocialMediaPlanner.Client.Brokers.API
{
    public partial class ApiBroker
    {
        private const string PostRelativeUrl = "api/posts";
        public async Task<List<PostForListVm>> GetAllPostsAsync() =>
            await this.GetAsync<List<PostForListVm>>(PostRelativeUrl);

        public async Task AddPostAsync(AddPostVM post) =>
            await this.PostAsync<AddPostVM>(PostRelativeUrl, post);
    }
}
