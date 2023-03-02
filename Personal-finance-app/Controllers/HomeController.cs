using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Personal_finance_app.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
            
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}