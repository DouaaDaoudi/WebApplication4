using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.NewFolder
{
    public class ApplicationDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Invoice> Invoices { get; set; } = null!;
    }
}
