using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using Wreddit.Kinds;

namespace Wreddit.Controllers
{
    public class Things
    {
        private Factory.ThingFactory factory;
        private string redditUrl = "https://www.reddit.com";
        public Things()
        {
            this.factory = new Factory.ThingFactory();
        }

        internal Thing GetThing(string url)
        {
            if (String.IsNullOrEmpty(url))
                throw new ArgumentNullException();

            var request = WebRequest.Create(String.Format("{0}/{1}.json", redditUrl, url));
            var response = request.GetResponse();
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                var obj = JToken.Parse(result);
                return factory.GetThing(obj);
            }
        }

        internal List<Thing> GetThings(string url)
        {
            if (url == null)
                throw new ArgumentNullException();

            var request = WebRequest.Create(String.Format("{0}/{1}.json", redditUrl, url));
            var response = request.GetResponse();
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                var obj = JToken.Parse(result);
                var list = new List<Thing>();
                foreach (var item in obj)
                {
                    list.Add(factory.GetThing(item));
                }
                return list;
            }
        }

        internal string parseSubreddit(string subreddit)
        {
            return new System.Text.RegularExpressions.Regex(@"^\/?r?\/?(?<sub>\w+)\/?")
                .Match(subreddit)
                .Groups["sub"]
                .ToString();
        }
    }
}
