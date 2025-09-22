using Microsoft.EntityFrameworkCore;
using FullStackMVC.Models;

namespace FullStackMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Subcliente> Subclientes { get; set; }
    }
}
