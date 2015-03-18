using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Solas1Db : DbContext
    {
        public DbSet<MenuList> Menu { get; set; }
        public DbSet<Booking> Event { get; set; }
        public DbSet<SolasReview> Reviews { get; set; }
    }
}
