using Data.Entity;
using Data.Entity.Address;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Data.Context
{
    public class YorGameContext : DbContext
    {
        public YorGameContext()
        {
            Database.Connection.ConnectionString = @"server=BILGISAYAR; database=YorGameDB; uid=sa; pwd=123";
        }

        public DbSet<AdminUser> AdminUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Post> Posts { get; set; }

        public DbSet<City> Cities { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<Neighborhood> Neighborhoods { get; set; }
        public DbSet<District> Districts { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
