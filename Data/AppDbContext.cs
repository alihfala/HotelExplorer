using lab6Dotnet.Models;
using Microsoft.EntityFrameworkCore;

namespace lab6Dotnet.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

   public DbSet<HotelsModel> Hotels {get; set;}
}