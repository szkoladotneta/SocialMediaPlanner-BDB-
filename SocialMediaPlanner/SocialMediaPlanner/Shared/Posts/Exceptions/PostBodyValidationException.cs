using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPlanner.Shared.Posts.Exceptions
{
    public class PostBodyValidationException :Exception
    {
        public PostBodyValidationException()
            :base(message: "Body has not been validated properly!")
        {

        }
    }
}
