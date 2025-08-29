using Microsoft.EntityFrameworkCore;
using Tripzy.Core.Models;

namespace Tripzy.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> User { get; set; }
}
