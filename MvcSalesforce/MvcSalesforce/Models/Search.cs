using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcSalesforce.Models
{
    public class Search
    {
        public int SearchID { get; set; }

        public string Location { get; set; }

        public int MinPrice { get; set; }

        public int MaxPrice { get; set; }

        public string Type { get; set; }

        public int MinAge { get; set; }

        public int MaxAge { get; set; }

        public int MinSquareFootage { get; set; }

        public int MaxSquareFootage { get; set; }
    }
}