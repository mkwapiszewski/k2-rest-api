using Microsoft.EntityFrameworkCore;
using Test.Persistence.Models;

namespace Test.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<tProduct> Products { get; set; }
}