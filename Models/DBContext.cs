using Microsoft.EntityFrameworkCore;
using web_api.Models;

namespace web_api.Models;

public class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    // public DbSet<<object>> <objects> { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }

}