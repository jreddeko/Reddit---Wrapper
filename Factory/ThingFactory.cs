using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;
using Wreddit.Kinds;

namespace Wreddit.Factory
{
    internal class ThingFactory
    {
        internal Thing GetThing(JToken obj)
        {

            if (obj["data"] == null)
                throw new ArgumentException("Unrecognized data format");

            var data = obj["data"];

            if ((string)obj["kind"] == "t1")
            {
                var comment = data.ToObject<Comment>();
                comment.kind = (string)obj["kind"];
                return comment;
            }
            else if ((string)obj["kind"] == "t2")
            {

            }
            else if ((string)obj["kind"] == "t3")
            {
                var link = data.ToObject<Link>();
                link.kind = (string)obj["kind"];
                return link;
            }
            else if ((string)obj["kind"] == "t4")
            {
            }
            else if ((string)obj["kind"] == "t5")
            {
                var subreddit = data.ToObject<Subreddit>();
                subreddit.kind = (string)obj["kind"];
                return subreddit;
            }
            else if ((string)obj["kind"] == "Listing")
            {
                var listing = data.ToObject<Listing>();
                listing.kind = (string)obj["kind"];
                return listing;
            }
            return null;
        }
    }
}
