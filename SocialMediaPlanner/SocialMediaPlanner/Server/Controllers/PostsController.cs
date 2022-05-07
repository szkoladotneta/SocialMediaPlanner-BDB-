using Microsoft.AspNetCore.Mvc;
using SocialMediaPlanner.Application.Posts.Queries.AllPostsQuery;
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
    }
}
