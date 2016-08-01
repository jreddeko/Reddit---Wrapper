using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wreddit.Kinds;

namespace Wreddit.Controllers
{
    public class Links : LinksAndCommentsAndMessages
    {
        public Link GetLink(string article)
        {
            var url = String.Format("{0}", article);
            var things = GetThings(url);
            var listing = Listing.Parse(things.First());
            return Link.Parse(listing.children.First());
        }

        /// <summary>
        /// Lock a link.
        /// Prevents a post from receiving new comments.
        /// </summary>
        /// <param name="id">fullname of a link</param>
        /// <param name="modhash">a modhash</param>
        /// <returns></returns>
        public string Lock(string id, object modhash)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Mark a link NSFW.
        /// </summary>
        /// <param name="id">fullname of a link</param>
        /// <param name="modhash">a modhash</param>
        /// <returns></returns>
        public string MarkNSFW(string id, object modhash)
        {
            throw new NotImplementedException();
        }


        public string set_subreddit_sticky()
        {
            throw new NotImplementedException();
        }

        public string set_suggested_sortmodposts();
        public string store_visitssave();
        public string SubmitLink();
        public string Unhide();
        public string Unlock();
        public string UnmarkNSFW();


    }
}
