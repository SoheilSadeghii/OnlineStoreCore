using Microsoft.EntityFrameworkCore;
using OnlineStoreCore.Models;

namespace OnlineStoreCore.Data
{
    public class OnlineStoreCoreContext : DbContext
    {
        public OnlineStoreCoreContext(DbContextOptions<OnlineStoreCoreContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
    }
}
