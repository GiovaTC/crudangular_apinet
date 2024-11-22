using Microsoft.EntityFrameworkCore;
using CrudApi.Models;
using Microsoft.Identity.Client;

namespace CrudApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
