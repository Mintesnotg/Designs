

using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace postGres.Models
{
    //public class first
    //{
    //    //[ScaffoldColumn(false)]
    //    //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    public int id { get; set; }
    //    public string name { get; set; }
    //    public bool isNull { get; set; }
    //}
    public class Students
    {
        //Table[("")]
        //[ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name { get; set; }
        public string department { get; set; }
    }
    public class Teachers
    {
        //[ScaffoldColumn(false)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string name { get; set; }
        public string department { get; set; }
        public string section { get; set; }
    }
}
