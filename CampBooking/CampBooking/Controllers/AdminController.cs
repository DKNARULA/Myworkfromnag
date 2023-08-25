using CampBooking.Data;
using CampBooking.Models;
using CampBooking.Models.ViewModels;
using FileUpload;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampBooking.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {

        private ApplicationDbContext _context;
        private UploadInterface _upload;
        public AdminController(ApplicationDbContext context, UploadInterface upload)
        {
            _context = context;
            _upload = upload;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult ManageCamp()
        {
            var getMovieList = _context.campDetails.ToList();
            return View(getMovieList);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }
            campDetails camp = new campDetails();
            var obj = _context.campDetails.Find(id);
            if(obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(campDetails obj)
        {
            _context.campDetails.Update(obj);
            _context.SaveChanges();
            return RedirectToAction("ManageCamp");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }
            campDetails camp = new campDetails();
            var obj = _context.campDetails.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        public IActionResult Delete(campDetails obj)
        {
            _context.campDetails.Remove(obj);
            _context.SaveChanges();
            return RedirectToAction("ManageCamp");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(IList<IFormFile> files, campDetailsViewModel vmodel, campDetails camp)
        {

            camp.campName = vmodel.campName;
            camp.capacity = vmodel.capacity;
            camp.price = vmodel.price;
            camp.desc = vmodel.desc;
            foreach (var item in files)
            {
                camp.image = "~/uploads/" + item.FileName.Trim();
            }
            _upload.uploadfilemultiple(files);
            _context.campDetails.Add(camp);
            _context.SaveChanges();
            
            return RedirectToAction("Create","Admin");


        }
        public string upload()
        {
            return ("");
        }


    }
}
