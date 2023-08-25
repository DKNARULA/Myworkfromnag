using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;


        // public HomeController(ILogger<HomeController> logger)
        //{
        //  _logger = logger;
        //}
        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Event> objList = _db.Events;
            return View(objList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("Customer-Support")]
        public RedirectResult CustomerSupport()
        {
            return Redirect("https://www.nagarro.com/en/contact-us");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
