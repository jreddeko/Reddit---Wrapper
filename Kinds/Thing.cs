using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Net;
using Newtonsoft.Json;
using System.IO;

namespace Wreddit.Kinds
{
    public class Thing
    {
        public string kind;
        public object data;
        public string name;
        public string id;

        public static Thing Create(string uri)
        {
            var request = WebRequest.Create(uri);
            var response = request.GetResponse();
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                var thing = JsonConvert.DeserializeObject<Thing>(result);
                return Subreddit.Parse(thing);
            }
        }

        public static List<Thing> GetByID(string uri)
        {
            var request = WebRequest.Create(uri);
            var response = request.GetResponse();
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<List<Thing>>(result); 
            }
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Thing))
                return false;

            if (!isSameData(obj as Thing))
                return false;

            return kind == ((Thing)obj).kind && name == ((Thing)obj).name && id == ((Thing)obj).id;
        }

        public override int GetHashCode()
        {
            return (7 * 13) + (kind == null ? 0 : kind.GetHashCode()) +
                (7 * 13) + (data == null ? 0 : data.ToString().GetHashCode()) +
                (7 * 13) + (name == null ? 0 : name.GetHashCode()) +
                (7 * 13) + (id == null ? 0 : id.GetHashCode());
        }

        public override string ToString()
        {
            return base.ToString();
        }

        private bool isSameData(Thing thing)
        {
            if ((data == null && thing.data != null) || (data != null && thing.data == null))
                return false;

            if (data == null && thing.data == null)
                return true;

            return data.ToString() == thing.data.ToString();
        }
    }
}
