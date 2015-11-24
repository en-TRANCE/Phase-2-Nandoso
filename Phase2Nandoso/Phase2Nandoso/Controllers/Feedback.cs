using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phase2Nandoso.Controllers
{
    public class Feedback
    {
        public int FeedbackID { get; set; }
        public string CommenterName { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }

        //[JsonIgnore]
        //public virtual Reply Reply { get; set; }
    }
}