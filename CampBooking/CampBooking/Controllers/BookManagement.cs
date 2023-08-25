using CampBooking.Data;
using CampBooking.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampBooking.Controllers
{
    public class BookManagement : Controller
    {
        private ApplicationDbContext _context;
        public BookManagement(ApplicationDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Find(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            BookingTable camp = new BookingTable();
            
            var obj = _context.BookingTables.Where(a => a.BookRefId == id).FirstOrDefault();

            if (obj == null)
            {
                return NotFound();
            }
            
            return View(obj);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
           
            var obj = _context.BookingTables.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(BookingTable obj)
        {
            _context.BookingTables.Update(obj);
            _context.SaveChanges();
            return RedirectToAction("find");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            var obj = _context.BookingTables.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(BookingTable obj)
        {
            _context.BookingTables.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
