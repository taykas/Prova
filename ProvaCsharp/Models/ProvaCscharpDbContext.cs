using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace ProvaCsharp.Models;

public class ProvaCscharpDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<User> Users => Set<User>();
    public DbSet<Tour> Tours => Set<Tour>();
    public DbSet<Point> Points => Set<Point>();
    public DbSet<ToursPoint> ToursPoint => Set<ToursPoint>();

    protected override void OnModelCreating(ModelBuilder model)
    {
        model.Entity<ToursPoint>()
            .HasOne(tp => tp.Tour)
            .WithMany(t => t.ToursPoints)
            .HasForeignKey(tp => tp.TourID)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<ToursPoint>()
            .HasOne(tp => tp.Point)
            .WithMany(p => p.ToursPoints)
            .HasForeignKey(tp => tp.PointID)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<ToursPoint>()
            .HasOne(tp => tp.User)
            .WithMany(u => u.ToursPoints)
            .HasForeignKey(tp => tp.UserID)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Tour>()
            .HasOne(p => p.User)
            .WithMany(u => u.Tours)
            .HasForeignKey(p => p.UserID)
            .OnDelete(DeleteBehavior.NoAction);

        model.Entity<Tour>()
            .HasMany(t => t.Points)
            .WithOne(p => p.Tour)
            .HasForeignKey(t => t.PointID)
            .OnDelete(DeleteBehavior.NoAction);


         model.Entity<User>()
            .HasIndex(u => u.UserName)
            .IsUnique();
    }

}