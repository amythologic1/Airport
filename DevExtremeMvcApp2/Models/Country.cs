using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExtremeMvcApp2.Models
{
    public class Country
    {
        public long id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string continent { get; set; }
        public string WikipediaLink { get; set; }
        public string keywords { get; set; }
    }
}