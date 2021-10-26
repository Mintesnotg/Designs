using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace postGres.Models
{
    public class PContext : DbContext
    {
        public PContext (DbContextOptions<PContext> options) : base(options) { }
        public DbSet<first> firsts { get; set; }
    }
}
