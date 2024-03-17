using ExpenseTracker.Models.Entities;
using ExpenseTracker.Models.InputModel;
using ExpenseTracker.Models.ViewModel;
using ExpenseTracker.Services.Application;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ExpenseService _expenseService;

        public HomeController(ExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        [Route("/")]
        public async Task<IActionResult> Index()
        {
            ExpenseViewModel viewModel = await _expenseService.GetAllExpenses();
            return View(viewModel);
        }

        [Route("/")]
        [HttpPost]
        public async Task<IActionResult> Index(ExpenseInputModel input)
        {
            
            Expense expense = await _expenseService.AddExpense(input);
            
            return LocalRedirect("/");
        }
    }
}
