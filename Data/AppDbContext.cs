using Microsoft.EntityFrameworkCore;
using Tripzy.Entities;

namespace Tripzy.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
}
