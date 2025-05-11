using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Config;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Link> Links { get; set; }

    public override int SaveChanges()
    {
        var entries = ChangeTracker.Entries()
            .Where(e => e.Entity is User && 
                        (e.State == EntityState.Modified));
    
        foreach (var entry in entries)
        {
            ((User)entry.Entity).UpdatedAt = DateTime.Now;
        }
    
        return base.SaveChanges();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UserConfig());
        modelBuilder.ApplyConfiguration(new LinkConfig());
        
        base.OnModelCreating(modelBuilder);
    }
}