using ExpenseTracker.Entities;

namespace ExpenseTracker.Models
{
    public class ExpenseViewModel
    {
        public ExpenseViewModel()
        {
            Expenses = new List<Expense>();
        }

        public ExpenseInputModel? Input { get; set; }
        public List<Expense>? Expenses { get; set; }
    }
}
