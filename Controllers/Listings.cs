using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wreddit.Kinds;

namespace Wreddit.Controllers
{
    public class Listings : Things
    {
        /// <summary>
        /// Get a listing of links by fullname.
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        public Listing GetByID(string[] names)
        {
            var url = String.Format("by_id/{0}", String.Join(",", names));
            var thing = GetThing(url);
            return Listing.Parse(thing);
        }

        /// <summary>
        /// Get the comment tree for a given Link
        /// </summary>
        /// <param name="subreddit"></param>
        /// <param name="article"></param>
        /// <returns></returns>
        public Listing GetComments(string article)
        {
            var url = String.Format("{0}", article);
            var things = GetThings(url);
            return Listing.Parse(things.Last());
        }

        /// <summary>
        /// Get the comment tree for a given Link and subreddit.
        /// </summary>
        /// <param name="subreddit"></param>
        /// <param name="article"></param>
        /// <returns></returns>
        public Listing GetComments(string subreddit, string article)
        {
            var url = String.Format("r/{0}/comments/{1}", parseSubreddit(subreddit), article);
            return GetComments(url);
        }

        public Listing GetLinks(string subreddit, string SearchPattern = null)
        {
            var url = String.Format("r/{0}/{1}", parseSubreddit(subreddit), SearchPattern);
            var thing = GetThing(url);
            return Listing.Parse(thing);
        }

        /// <summary>
        /// Return a list of other submissions of the same article
        /// </summary>
        /// <param name="article"></param>
        /// <returns></returns>
        public Listing GetDuplicates(string article)
        {
            var url = String.Format("duplicates/{0}/", article);
            var thing = GetThing(url);
            return Listing.Parse(thing);
        }

        /// <summary>
        /// The Serendipity button
        /// </summary>
        /// <param name="subreddit"></param>
        /// <returns>Listing for kind Comment and Listing for kind Link</returns>
        public List<Thing> GetRandom(string subreddit = null)
        {
            if (String.IsNullOrEmpty(subreddit))
            {
                var url = String.Format("random/");
                return GetThings(url);
            }
            else
            {
                var url = String.Format("r/{0}/random/");
                return GetThings(url);
            }
        }

        public object morechildren()
        {
            throw new NotImplementedException();
        }
    }
}
