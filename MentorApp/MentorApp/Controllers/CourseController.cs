using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MentorApp.DAL;
using MentorApp.Migrations;
using MentorApp.Models;
using MentorApp.ViewModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace MentorApp.Controllers
{
    public class CourseController : Controller
    {
        private readonly MentorDbContext _context;
        public CourseController(MentorDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            CourseViewModel vm = new CourseViewModel
            {
                Courses = _context.Courses.Include(x=>x.CourseTeachers).ThenInclude(x=>x.Teacher).ToList(),
                Categories = _context.Categories.ToList()
            };
            return View(vm);
        }
    }
}
