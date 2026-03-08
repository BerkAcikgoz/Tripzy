using Microsoft.EntityFrameworkCore;
using Tripzy.Core.Entity;

namespace Tripzy.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<PlaceCategory> PlaceCategories { get; set; }

        public DbSet<Place> Places { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Favorite> Favorites { get; set; }

        public DbSet<Photo> Photos { get; set; }
}
