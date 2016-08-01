using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Web.Script.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using Wreddit.Controllers;

namespace Wreddit
{
    public class Reddit
    {
        public Listings Listings { get; set; }
        public Comments Comments { get; set; }
        public Links Links { get; set; }
        public Subreddits Subreddits { get; set; }

        public Reddit()
        {
            this.Listings = new Listings();
            this.Comments = new Comments();
            this.Links = new Links();
            this.Subreddits = new Subreddits();
        }

        public string LogIn(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
