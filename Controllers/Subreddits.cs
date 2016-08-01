using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Wreddit.Kinds;

namespace Wreddit.Controllers
{
    public class Subreddits : Things
    {
        public Subreddit GetSubreddit(string subreddit)
        {
            var url = String.Format("r/{0}/about", parseSubreddit(subreddit));
            var thing = this.GetThing(url);
            return Subreddit.Parse(thing);
        }
    }
}
