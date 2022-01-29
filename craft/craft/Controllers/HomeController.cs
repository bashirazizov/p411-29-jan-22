using craft.DAL;
using craft.Models;
using craft.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace craft.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext dbContext;
        public HomeController(AppDbContext db)
        {
            dbContext = db;
        }

        public IActionResult Index()
        {
            HomeViewModel hvm = new HomeViewModel
            {
                banner = dbContext.Banners.FirstOrDefault(),
                projects = dbContext.Projects.ToList(),
                workers = dbContext.Workers.ToList(),
                categories = dbContext.Categories.ToList(),
                testimonials = dbContext.Testimonials.ToList(),
                news = dbContext.News.ToList(),
                services = dbContext.Services.ToList()
            };

            return View(hvm);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Category(int? id)
        {
            return View(dbContext.Categories.Include(x => x.Projects).FirstOrDefault(x => x.Id == id));
        }
    }
}
