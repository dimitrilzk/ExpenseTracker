using ExpenseTracker.Entities;
using ExpenseTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseTracker.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/")]
        [HttpPost]
        public IActionResult Index(ExpenseInputModel input)
        {
            ExpenseViewModel model = new ExpenseViewModel();
            model.Expenses.Add(new Expense
            {
                Id = Guid.NewGuid(),
                ExpenseName = input.Name,
                Quantity = (int)input.Quantity,
                UnitPrice = (decimal)input.Price,
                TotalPrice = (decimal)(input.Price * input.Quantity)
            });

            return View(model);
        }
    }
}
