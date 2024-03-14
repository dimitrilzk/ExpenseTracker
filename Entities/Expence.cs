namespace ExpenseTracker.Entities
{
    public class Expence
    {
        public Guid Id { get; set; }
        public string? ExpenceName { get; set; }
        public decimal Price { get; set; }
    }
}
