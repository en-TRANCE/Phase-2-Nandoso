using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Phase2Nandoso.Controllers
{
    public class Specials
    {
        public int SpecialsID { get; set; }
        public string SpecialsName { get; set; }
        public string SpecialsDetail { get; set; }
        public string SpecialPrice { get; set; }
        public int MenuID { get; set; }

        //[JsonIgnore]
        public virtual ICollection<Menu> Menu { get; set; }
    }
}