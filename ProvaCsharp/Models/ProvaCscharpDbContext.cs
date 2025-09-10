using Microsoft.EntityFrameworkCore;

namespace ProvaCsharp.Models;

public class ProvaCscharpDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Tour> Tours => Set<Tour>();
    public DbSet<Point> Points => Set<Point>();
    public DbSet<>

    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<Passeio>()
            .HasOne(p => p.User)
            .WithMany(u => u.Passeios)
            .HasForeignKey(p => p.UserID)
            .OnDelete(DeleteBehavior.NoAction);
    }

}