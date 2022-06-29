using Bikin.DAL;
using Bikin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bikin.Areas.Manage.Controllers
{
    public class ServiceController : Controller
    {
        private AppDbContext _context;

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var services = _context.Services.ToList();
            return View(services);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Service service)
        {
            if (!ModelState.IsValid)
                return View();

            _context.Services.Add(service);
            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            var service = _context.Services.FirstOrDefault(x=>x.Id == id);

            if (service == null)
                return RedirectToAction("error","dashboard");

            return View(service);
        }
        [HttpPost]
        public IActionResult Edit(Service service)
        {
            var existServise = _context.Services.FirstOrDefault(x=>x.Id == service.Id);

            if (existServise == null)
                return RedirectToAction("error","dashboard");

            if (!ModelState.IsValid)
                return View();

            existServise.Title = service.Title;
            existServise.SubTitle = service.SubTitle;
            existServise.Desc = service.Desc;
            existServise.Icon = service.Icon;

            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            var service = _context.Services.FirstOrDefault(x=>x.Id == id);

            if (service == null)
                return RedirectToAction("error","dashboard");

            return View(service);
        }
        [HttpPost]
        public IActionResult Delete(Service service)
        {
            var existService = _context.Services.FirstOrDefault(x => x.Id == service.Id);

            if (existService == null)
                return RedirectToAction("error","dashboard");

            _context.Services.Remove(existService);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
