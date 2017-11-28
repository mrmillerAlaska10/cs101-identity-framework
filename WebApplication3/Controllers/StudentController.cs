using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;

namespace WebApplication3.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Module()
        {
            var entities = new ApplicationDbContext();
            System.Console.WriteLine(entities.Lessons.ToString());
            return View(entities.Lessons.ToList());
        }
        public IActionResult Lesson(int id)
        {
            return View();
        }
    }
}