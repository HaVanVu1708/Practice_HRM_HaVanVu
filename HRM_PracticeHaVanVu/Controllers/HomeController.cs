using HRM_PracticeHaVanVu.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace HRM_PracticeHaVanVu.Controllers
{
    public class HomeController : Controller
    {

        private IEmployeeRepository repository;

        public HomeController(IEmployeeRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index() => View(repository.Employees.OrderBy(p => p.ID));


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
