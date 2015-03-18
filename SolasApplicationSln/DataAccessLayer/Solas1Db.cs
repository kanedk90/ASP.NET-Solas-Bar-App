using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    //Create interface for testing purposes
    public interface ISolas1Db : IDisposable
    {
        IQueryable<T> Query<T>() where T : class;

    }

    // -- ISolasDb4 is the used for mock interface purposes in testing
    public class Solas1Db : DbContext,  ISolas1Db
    {
        public DbSet<MenuList> Menu { get; set; }
        public DbSet<Booking> Event { get; set; }
        public DbSet<SolasReview> Reviews { get; set; }
        

        IQueryable<T> ISolas1Db.Query<T>()
        {
            return Set<T>();
        }
    }
}
