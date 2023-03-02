using Microsoft.AspNetCore.Mvc;
using Personal_finance_app.Models.VIewModels;
using Personal_finance_app.Respositories;
using System.Diagnostics;

namespace Personal_finance_app.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBudgetRepository _budgetRepository;

        public HomeController(IBudgetRepository budgetRepository)
        {
            _budgetRepository = budgetRepository;
        }

        public IActionResult Index()
        {
            var transactions = _budgetRepository.GetTransactions();

            var viewModel = new BudgetViewModel
            {
                Transactions = transactions
            };

            return View(viewModel);
        }
    }
}