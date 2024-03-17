using ExpenseTracker.Models.Entities;
using ExpenseTracker.Models.InputModel;
using ExpenseTracker.Models.ViewModel;
using ExpenseTracker.Services.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace ExpenseTracker.Services.Application
{
    public class ExpenseService
    {
        private readonly ApplicationDbContext _dbContext;
        public ExpenseService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Expense> AddExpense(ExpenseInputModel inputModel)
        {
            Expense expense = new Expense()
            {
                Id = Guid.NewGuid(),
                ExpenseName = inputModel.Name,
                Quantity = (int)inputModel.Quantity,
                UnitPrice = (decimal)inputModel.Price,
                TotalPrice = (decimal)(inputModel.Price * inputModel.Quantity)
            };

            _dbContext.Add(expense);
            await _dbContext.SaveChangesAsync();
            return expense;
        }

        public async Task<ExpenseViewModel> GetAllExpenses()
        {
            var expenses = await _dbContext.Expenses.ToListAsync();

            var expenseViewModel = new ExpenseViewModel
            {
                Expenses = expenses.Select(x => new Expense
                {
                    Id = x.Id,
                    ExpenseName = x.ExpenseName,
                    Quantity = x.Quantity,
                    UnitPrice = x.UnitPrice,
                    TotalPrice = x.TotalPrice
                }).ToList()
            };

            return expenseViewModel;
        }
    }
}
