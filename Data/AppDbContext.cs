using AmonyCoffeeMIS.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Reflection.Emit;
using System;

namespace AmonyCoffeeMIS.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<Farmer>()
            .Property(s => s.Gender)
            .HasConversion(new EnumToStringConverter<Gender>());
    }

    public DbSet<Farmer> Farmer { get; set; }

    public DbSet<Delivery> Deliveries { get; set; }
}