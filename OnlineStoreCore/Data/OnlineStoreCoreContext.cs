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
        public DbSet<CategoryToProduct> CategoryToProducts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Seed Data Category

            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 1,
                Name = "ASP.NET Core",
                Description = ".NET CORE 9"
            },
            new Category()
            {
                Id = 2,
                Name = "لباس ورزشی",
                Description = "گروه لباس ورزشی"
            },
            new Category()
            {
                Id = 3,
                Name = "ساعت مچی",
                Description = "گروه ساعت مچی"
            },
            new Category()
            {
                Id = 4,
                Name = "لوازم منزل",
                Description = "گروه لوازم منزل"
            });

            #endregion
            base.OnModelCreating(modelBuilder);
        }
    }
}
