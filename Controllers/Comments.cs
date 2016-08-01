using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wreddit.Controllers
{
    public class Comments : LinksAndCommentsAndMessages
    {
        /// <summary>
        /// Submit a new comment or reply to a message.
        /// </summary>
        /// <param name="api_type">the string json</param>
        /// <param name="text">raw markdown text</param>
        /// <param name="thing_id">fullname of parent thing</param>
        /// <param name="modhash">a modhash</param>
        /// <returns></returns>
        public string Submit(string api_type, string text, string thing_id, object modhash)
        {
            throw new NotImplementedException();
        }
    }
}
