using Data.Animal.Entities;
using Data.Register.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data;

public class Context : DbContext
{
    public DbSet<EAnimal>? Animal { get; set; }
    
    public DbSet<EUser>? Users { get; set; }

    public Context()
    {
    }

    public Context(DbContextOptions<Context> options) : base(options)
    {
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=../Data/animals.db");
        }
    }
}