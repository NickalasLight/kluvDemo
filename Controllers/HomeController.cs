using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using klovecore2.Models;

namespace klovecore2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Employees()
        {
            return Redirect("/Employees");
        }
        public IActionResult Departments()
        {
            return Redirect("/Departments");
        }

        public IActionResult DepartmentOverview()
        {
            return Redirect("/DepartmentOverview");
        }

        



        public IActionResult Index()
        {
            return View();
        }

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
