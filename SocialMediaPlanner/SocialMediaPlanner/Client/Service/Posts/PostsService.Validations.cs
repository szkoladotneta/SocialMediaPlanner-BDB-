using SocialMediaPlanner.Shared.Posts.Commands;
using SocialMediaPlanner.Shared.Posts.Exceptions;

namespace SocialMediaPlanner.Client.Service.Posts
{
    public partial class PostsService
    {
        public static void ValidatePost(AddPostVM post)
        {
            if (post == null)
            {
                throw new PostNullException();
            }
            if (post.Body.Length <= 10)
            {
                throw new PostBodyValidationException();
            }
        }
    }
}
