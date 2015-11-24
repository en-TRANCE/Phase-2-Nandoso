using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phase2Nandoso.Controllers
{
    public class Menu
    {
        public int ID { get; set; }
        public string MenuName { get; set; }
        public string MenuDetail { get; set; }
        public string MenuPrice { get; set; }
        public int CategoryID { get; set; }

        [JsonIgnore]
        public virtual Category Category { get; set; }
        [JsonIgnore]
        public virtual Specials Specials { get; set; }
    }
}