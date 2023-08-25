using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    public class MyEvents : Controller
    {
        private readonly ApplicationDbContext _db;
        public MyEvents(ApplicationDbContext db)
        {
            _db = db;
        }

        [Authorize]
        public IActionResult Index()
        {
            IEnumerable<Event> objList = _db.Events;
            return View(objList);
        }
    }
}