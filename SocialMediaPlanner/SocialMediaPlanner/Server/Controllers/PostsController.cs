using Microsoft.AspNetCore.Mvc;
using SocialMediaPlanner.Application.Posts.Commands.AddPostCommand;
using SocialMediaPlanner.Application.Posts.Queries.AllPostsQuery;
using SocialMediaPlanner.Shared.Posts.Commands;
using SocialMediaPlanner.Shared.Posts.Queries.AllPostsQuery;

namespace SocialMediaPlanner.Server.Controllers
{
    [Route("api/posts")]
    public class PostsController : BaseController
    {

        [HttpGet]
        public async Task<ActionResult<List<PostForListVm>>> GetAsync()
        {
            var vm = await Mediator.Send(new AllPostsQuery());
            return vm;
        }

        [HttpPost]
        public async Task<ActionResult<int>> PostAsync(AddPostVM post)
        {
            var id = await Mediator.Send(new AddPostCommand() { Post = post });
            return id;
        }
    }
}
