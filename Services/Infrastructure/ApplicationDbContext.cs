using ExpenseTracker.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Services.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
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
