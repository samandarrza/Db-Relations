using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using YummyApp.DAL;
using YummyApp.Migrations;
using YummyApp.Models;
using YummyApp.ViewModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace YummyApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly YummyDbContext _context;

        public HomeController(YummyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeViewModel vm = new HomeViewModel {
                Testimonials = _context.Testimonials.Include(x=>x.Positions).ToList(),
                Categories = _context.Categories.Include(x=>x.Meals).ThenInclude(x=>x.MealIngredients).ThenInclude(x=>x.Ingredient).ToList(),
                
            };

            return View(vm);
        }
    }
}
