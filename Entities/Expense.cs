namespace ExpenseTracker.Entities
{
    public class Expense
    {
        public Guid Id { get; set; }
        public string? ExpenseName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; } = 1;
        public decimal TotalPrice { get; set; }

    }
}
