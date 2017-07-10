using System.Data.Entity;
using WatchStore.Models;

namespace WatchStore.DAL
{
    public class WatchContext: DbContext
    {
        public WatchContext()
            : base("name=WatchStoreConnection")
        {
        }

        public DbSet<Watch> Watchs { get; set; }
        public DbSet<Collection> Collections { get; set; }
    }
}