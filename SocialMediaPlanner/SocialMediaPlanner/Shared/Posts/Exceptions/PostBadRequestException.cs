using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPlanner.Shared.Posts.Exceptions
{
    public class PostBadRequestException : Exception
    {
        public PostBadRequestException(Exception ex)
            : base(message: "Bad request occured when trying to send post!", ex)
        {

        }
    }
}
