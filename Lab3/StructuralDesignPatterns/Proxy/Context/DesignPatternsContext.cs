using Microsoft.EntityFrameworkCore;
using StructuralDesignPatterns.Proxy.Models;

namespace StructuralDesignPatterns.Proxy.Context;

public class DesignPatternsContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=.;Database=DPDB;Trusted_Connection=True;");
    }
}