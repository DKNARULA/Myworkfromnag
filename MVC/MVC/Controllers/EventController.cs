using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC.Data;
using MVC.Models;
using System.Net;

namespace MVC.Controllers
{
    public class EventController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EventController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Event> objList = _db.Events;
            return View(objList);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // post - create

        [HttpPost]

        public IActionResult Create(Event obj)
        {
            
                _db.Events.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            

        }
        //public ActionResult Details(string title)
        //{
        //    if (title == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Event obj = _db.Events.Find(title);
        //    if (obj == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(obj);
        //}

        //private ActionResult HttpNotFound()
        //{
        //    throw new NotImplementedException();
        //}

        public IActionResult Details(string title)
        {
            if (title == null)
            {
                return NotFound();
            }
            var obj = _db.Events.Find(title);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [Authorize]
        // get -update
        public IActionResult Update(string title)
        {
            if (title == null)
            {
                return NotFound();
            }
            var obj = _db.Events.Find(title);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        //post-update


        [HttpPost]

        public IActionResult Update(Event obj)
        {
            _db.Events.Update(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
