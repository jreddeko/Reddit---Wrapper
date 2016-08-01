using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wreddit.Controllers
{
    public class LinksAndComments : Things
    {

        /// <summary>
        /// Delete a Link or Comment.
        /// </summary>
        /// <param name="id">fullname of a thing created by the user</param>
        /// <param name="modhash">a modhash</param>
        /// <returns></returns>
        public string Delete(string id, object modhash)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Edit the body text of a comment or self-post.
        /// </summary>
        /// <param name="api_type">the string json</param>
        /// <param name="text">raw markdown text</param>
        /// <param name="thing_id">fullname of parent thing</param>
        /// <param name="modhash">a modhash</param>
        /// <returns></returns>
        public string EditUserText(string api_type, string text, string thing_id, object modhash)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Hide a link.
        /// This removes it from the user's default view of subreddit listings.
        /// </summary>
        /// <param name="id">A list of link fullnames</param>
        /// <param name="modhash">a modhash</param>
        /// <returns></returns>
        public string Hide(string[] id, object modhash)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save a link or comment.
        /// Saved things are kept in the user's saved listing for later perusal.
        /// </summary>
        /// <param name="category">a category name</param>
        /// <param name="id">fullname of a thing</param>
        /// <param name="modhash">a modhash</param>
        /// <returns></returns>
        public string Save(string category, string id, object modhash)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get a list of categories in which things are currently saved.
        /// </summary>
        /// <returns></returns>
        public string SavedCategories()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Enable or disable inbox replies for a link or comment.
        /// state is a boolean that indicates whether you are enabling or disabling inbox replies - true to enable, false to disable.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="state"></param>
        /// <param name="modhas"></param>
        /// <returns></returns>
        public string SendReplies(string id, bool state, object modhas)
        {
            throw new NotImplementedException();
        }

        public string set_contest_modemodposts()
        {
            throw new NotImplementedException();
        }

        public string Unsave();
        public string Vote();
    }
}
