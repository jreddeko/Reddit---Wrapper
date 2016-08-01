using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json.Linq;

namespace Wreddit.Kinds
{
    public class Subreddit : Thing
    {
        public string submit_text_html;
        public bool? user_is_banned;
        public bool? wiki_enabled;
        public bool? user_is_contributor;
        public string submit_text;
        public string display_name;
        public Uri header_img;
        public string description_html;
        public string title;
        public bool? collapse_deleted_comments;
        public string public_description;
        public bool? over18;
        public string public_description_html;
        public object community_rules;
        public object icon_size;
        public string suggested_comment_sort;
        public object icon_img;
        public string header_title;
        public string description;
        public bool? user_is_muted;
        public string submit_link_label;
        public string accounts_active;
        public bool? public_traffic;
        public object header_size;
        public int subscribers;
        public string submit_text_label;
        public string lang;
        public object key_color;
        public decimal created;
        public string url;
        public bool? quarantine;
        public bool? hide_ads;
        public decimal created_utc;
        public string banner_size;
        public bool? user_is_moderator;
        public bool? user_sr_theme_enabled;
        public int comment_score_hide_mins;
        public string subreddit_type;
        public string submission_type;
        public bool? user_is_subscriber;

        public static Subreddit Parse(Thing thing)
        {
            if (typeof(Subreddit).Equals(thing.GetType()))
                return (Subreddit)thing;
            return null;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Subreddit))
                return false;

            return id == ((Subreddit)obj).id && name == ((Subreddit)obj).name;
        }

        public override int GetHashCode()
        {
            return (5 * 17) + (id == null ? 0 : id.GetHashCode()) +
                   (5 * 17) + (name == null ? 0 : name.GetHashCode());
        }

        public override string ToString()
        {
            return this.display_name;
        }
    }
}
