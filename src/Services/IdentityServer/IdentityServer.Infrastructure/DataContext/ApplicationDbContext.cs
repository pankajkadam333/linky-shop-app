using Microsoft.EntityFrameworkCore;
using IdentityServer.Domain.Entities;

namespace IdentityServer.Infrastructure.DataContext;
public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
