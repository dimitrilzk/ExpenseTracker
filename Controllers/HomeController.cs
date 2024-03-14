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
            ExpenseInputModel model = new()
            {
                ExpenseName = input.ExpenseName,
                Price = input.Price,
            };
            //List<ExpenseInputModel> expenses = new List<ExpenseInputModel>();
            //expenses.Add(input);

            return View(model);
        }
    }
}
