using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaPlanner.Shared.Posts.Exceptions
{
    public class PostNullException : Exception
    {
        public PostNullException()
            :base(message: "Null post error occured!")
        {

        }
    }
}
