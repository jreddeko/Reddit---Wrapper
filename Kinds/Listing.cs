using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace Wreddit.Kinds
{
    public class Listing : Thing
    {
        public string modhash;
        public List<Thing> children;
        public string after;
        public string before;

        public static Listing Parse(Thing thing)
        {
            if (typeof(Listing).Equals(thing.GetType()))
                return (Listing)thing;
            return null;
        }
    }
}
