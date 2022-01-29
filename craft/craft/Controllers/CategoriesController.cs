using craft.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace craft.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly AppDbContext dbContext;
        public CategoriesController(AppDbContext db)
        {
            dbContext = db;
        }
        public IActionResult Index(int? id)
        {
            return View(dbContext.Categories.Include(x=>x.Projects).FirstOrDefault(x=>x.Id==id));
        }
    }
}
