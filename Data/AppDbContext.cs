using AmonyCoffeeMIS.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AmonyCoffeeMIS.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    public DbSet<Farmer> Farmer{get;set;}
}