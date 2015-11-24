using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phase2Nandoso.Controllers
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public int MenuID { get; set; }

        [JsonIgnore]
        public virtual ICollection<Menu> Menu { get; set; }
    }
}