using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Wreddit.Kinds
{
    public class Link : Thing
    {
        public string author;
        public string author_flair_css_class;
        public string author_flair_text;
        public bool? clicked;
        public string domain;
        public bool? hidden;
        public bool? is_self;
        public bool? likes;
        public string link_flair_css_class;
        public string link_flair_text;
        public bool? locked;
        public object media;
        public object media_embed;
        public int num_comments;
        public bool? over_18;
        public string permalink;
        public bool? saved;
        public int score;
        public string selftext;
        public string selftext_html;
        public string subreddit;
        public string subreddit_id;
        public string thumbnail;
        public string title;
        public string url;
        public long edited;
        public string distinguished;
        public bool? stickie;
        public Listing comments;

        public static Link Parse(Thing thing)
        {
            if (thing is Link)
                return (Link)thing;

            if (thing.data is JObject)
                return ((JObject)thing.data).ToObject<Link>();

            return null;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Link))
                return false;

            return title == ((Link)obj).title && url == ((Link)obj).url && edited == ((Link)obj).edited;
        }

        public override int GetHashCode()
        {
            return (3 * 13) + (title == null ? 0 : title.GetHashCode()) +
                   (3 * 13) + (url == null ? 0 : url.GetHashCode()) +
                   (3 * 13) + (edited.GetHashCode());
        }

        public override string ToString()
        {
            return this.title;
        }
    }
}
