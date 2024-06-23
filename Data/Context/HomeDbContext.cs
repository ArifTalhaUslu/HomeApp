using Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Context;

public class HomeDbContext : DbContext
{
    public DbSet<Expense> Expense { get; set; }
    public DbSet<ExpenseType> ExpenseType { get; set; }
   
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=HomeTestDb;Integrated Security=true;Encrypt=False");
        base.OnConfiguring(optionsBuilder);
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Harcama 
        modelBuilder.Entity<Expense>().Property(h => h.ExpenseDate).HasColumnType("DATE");
        modelBuilder.Entity<Expense>().Property(h => h.Cost).HasColumnType("FLOAT");

        //Harcama Tip
        modelBuilder.Entity<ExpenseType>().Property(h => h.Name).HasColumnType("VARCHAR").HasMaxLength(200);
        modelBuilder.Entity<ExpenseType>().HasIndex(h => h.Name).IsUnique(true);

        base.OnModelCreating(modelBuilder);
    }

}
