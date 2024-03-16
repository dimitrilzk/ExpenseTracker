﻿namespace ExpenseTracker.Models
{
    public class ExpenseInputModel
    {
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; } = 1;
    }
}
