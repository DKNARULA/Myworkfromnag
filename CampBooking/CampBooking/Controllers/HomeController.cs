using CampBooking.Data;
using CampBooking.Models;
using CampBooking.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CampBooking.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;
       

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;

        }

        public IActionResult Index(int pg=1)
        {
            var getMovieList = _context.campDetails.ToList();

            const int pageSize = 5;
            if (pg < 1)
                pg = 1;
            int recscount = getMovieList.Count();
            var pager = new Pager(recscount, pg, pageSize);
            int recskip = (pg - 1) * pageSize;
            var data = getMovieList.Skip(recskip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;
            return View(data);
        }

        [HttpGet]
        public IActionResult BookNow(int id)
        {
            bookNowViewModel vm = new bookNowViewModel();
            var item = _context.campDetails.Where(a => a.id == id).FirstOrDefault();
            vm.campid = id;
            vm.campName = item.campName;
            return View(vm);
        }

        [HttpPost]
        public IActionResult BookNow(bookNowViewModel vm)
        {
            campDetails camp = new campDetails();
            var item = _context.campDetails.Find(vm.campid);
            //var item = _context.campDetails.Where(a => a.id == vm.campid).FirstOrDefault();
            List<BookingTable> booking = new List<BookingTable>();
            int num = vm.noofpeople;
            int cap = item.capacity;
            Random rndm = new Random();
            int id = rndm.Next(10000, 100000);
            if (checkAvail(num, cap))
            {
                booking.Add(new BookingTable {BookRefId=id,campid = vm.campid, campName = vm.campName, noofpeople = num, checkInDate = vm.checkInDate, checkOutDate = vm.checkOutDate, billAddress = vm.billAddress,
                state=vm.state,country=vm.country,pinCode=vm.pinCode,mobile=vm.mobile,amount=num*item.price});
                item.capacity = cap - num;
                _context.campDetails.Update(item);
                _context.SaveChanges();
                foreach (var itm in booking)
                {
                    _context.BookingTables.Add(itm);
                    _context.SaveChanges();
                }
                
                TempData["Success"] = "Camp Booked, BookingId:"+id+" Price:"+num*item.price;
            }
            else
            {
                TempData["availmsg"] = "Not Enough Availabilty";

            }


            return RedirectToAction("BookNow");
        }


        private bool checkAvail(int num, int cap)
        {
            bookNowViewModel vm = new bookNowViewModel();
            
            if (num > cap)
            {
                return false;
            }
            return true;
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
