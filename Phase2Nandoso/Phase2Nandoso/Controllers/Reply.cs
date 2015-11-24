using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phase2Nandoso.Controllers
{
    public class Reply
    {
        public int ReplyID { get; set; }
        public string ReplyerName { get; set; }
        public string ReplyComment { get; set; }
        public int FeedbackID { get; set; }
    }

    //[JsonIgnore]
    //public virtual ICollection<Feedback> Feedback { get; set; }
}