using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Models.Entities
{
    public class Expense
    {
        [Key]
        public Guid Id { get; set; }
        [StringLength(200)]
        public string? ExpenseName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

    }
}
