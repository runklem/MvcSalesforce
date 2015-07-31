using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSalesforce.Models
{
    public class SiteUser
    {
        public int SiteUserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string CurrentCity { get; set; }

        public string MadisonRegion { get; set; }

        public int Income { get; set; }
    }
}