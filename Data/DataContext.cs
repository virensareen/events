using Data.Tables;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data;

public class DataContext : DbContext
{
    private readonly string _connectionString;

    public DataContext(IConfiguration configuration)
    {
        _connectionString = configuration.GetConnectionString("db") ?? throw new InvalidOperationException();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_connectionString);
    }
    
    public DbSet<Gig> Gig { get; set; }
    public DbSet<Promoter> Promoter { get; set; }
    public DbSet<Venue> Venue { get; set; }
    public DbSet<Cost> Cost { get; set; }
    public DbSet<Invoice> Invoice { get; set; }
}