using Audit_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Audit_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        public DbSet<Kind> Kind { get; set; }
        public DbSet<User> User { get; set; }
    }
}