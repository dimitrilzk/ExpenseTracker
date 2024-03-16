using ExpenseTracker.Models.Entities;
using ExpenseTracker.Models.InputModel;

namespace ExpenseTracker.Models.ViewModel
{
    public class ExpenseViewModel
    {
        //public ExpenseViewModel()
        //{
        //    Expenses = new List<Expense>();
        //}

        public ExpenseInputModel? Input { get; set; }
        public List<Expense>? Expenses { get; set; }
    }
}
