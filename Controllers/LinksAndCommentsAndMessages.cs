using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wreddit.Controllers
{
    public class LinksAndCommentsAndMessages : LinksAndComments
    {
        /// <summary>
        /// Report a link, comment or message.
        /// Reporting a thing brings it to the attention of the subreddit's moderators. Reporting a message sends it to a system for admin review.
        /// For links and comments, the thing is implicitly hidden as well (see /api/hide for details).
        /// </summary>
        /// <param name="api_type">the string json</param>
        /// <param name="other_reason">	a string no longer than 100 characters</param>
        /// <param name="reason">a string no longer than 100 characters</param>
        /// <param name="site_reason">	a string no longer than 100 characters</param>
        /// <param name="thing_id">fullname of a thing</param>
        /// <param name="modhask">a modhash</param>
        /// <returns></returns>
        public string Report(string api_type, string other_reason, string reason, string site_reason, string thing_id, object modhask)
        {
            throw new NotImplementedException();
        }
    }
}
