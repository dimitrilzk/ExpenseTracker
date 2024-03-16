using ExpenseTracker.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Models.Data
{
    public class ExpensesDbContext : DbContext
    {
        public ExpensesDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Expense> Expenses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Expense>().ToTable("Expenses");
        }
    }
}
