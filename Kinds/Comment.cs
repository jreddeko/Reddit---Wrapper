using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Wreddit.Kinds
{
    public class Comment : Thing
    {
        public string approved_by;
        public string author;
        public string author_flair_css_class;
        public string author_flair_text;
        public string banned_by;
        public string body;
        public string body_html;
        public object edited;
        public int? gilded;
        public bool? likes;
        public string link_author;
        public string link_id;
        public string link_title;
        public string link_url;
        public int? num_reports;
        public string parent_id;
        public Thing replies;
        public bool? saved;
        public int? score;

        public static Comment Parse(Thing thing)
        {
            if (thing is Comment)
                return (Comment)thing;

            if (thing.data is JObject)
                return ((JObject)thing.data).ToObject<Comment>();

            return null;
        }
    }
}
