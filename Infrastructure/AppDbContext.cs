using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class AppDbContext : DbContext
{
    AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
    
    public DbSet<User> Users { get; set; }
}