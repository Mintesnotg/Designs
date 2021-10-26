using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace postGres.Models
{
    public class first
    {
        public int id { get; set; }
        public string name { get; set; }
        public bool isNull { get; set; }
        public first(string name,bool isNull)
        {
            this.isNull = isNull;
            this.name = name;
        }
       
    }
}
