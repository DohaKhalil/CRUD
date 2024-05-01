
using Crud.Repository.Data.Config;
using CRUDSystem.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CRUDSystem.Data
{
    public class StoreDBContext: DbContext
    {
        public StoreDBContext(DbContextOptions<StoreDBContext> options):base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductConfigration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Producte> productes { get; set; }
        public DbSet<Categorey> categorey { get; set; }
   

    }

}
