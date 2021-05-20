using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ScheduleApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ScheduleApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Schedule()
        {
            return Redirect("/Schedule/Index");
        }
        
        public IActionResult SignUp()
        {
            return Redirect("/SignUp/Index");
        }

        public IActionResult Log()
        {
            this.Page.Response.Write("No user in our db");
            return View();

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
