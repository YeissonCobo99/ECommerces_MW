using ECommerces_MW.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerces_MW.DAL
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
        {
        
        }

        public DbSet <Country> Countries { get; set; }


    }
}
