using CollectionTracking.Entities.Concrete;
using System.Data.Entity;

namespace CollectionTracking.DataAccess.Concrete.EntityFramework
{
    public class CollectionTrackingContext : DbContext
    {
        public CollectionTrackingContext() : base("CollectionTrackingDb")
        {
            Database.SetInitializer<CollectionTrackingContext>(null);
        }
        public DbSet<Film> Films { get; set; }
    }
}
