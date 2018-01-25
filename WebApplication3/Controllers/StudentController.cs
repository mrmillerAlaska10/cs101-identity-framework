using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;
using WebApplication3.ViewModels.StudentViewModels;
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

        public IActionResult Enrollment(EnrollViewModel model)
        {
            var entities = new ApplicationDbContext();
            System.Console.WriteLine(entities.Courses.ToString());
            return View(entities.Courses.ToList());
        }
        public IActionResult Lesson(int id)
        {
            return View();
        }

        public IActionResult Grades(int id)
        {
            var entities = new ApplicationDbContext();
            //var Grades = 
            int sID = id;
            ViewData["grades"] = entities.Grades.ToList();
            ViewData["student_id"] = sID;
            ViewData["lessons"] = entities.Lessons.ToList();
            return View(ViewData);
        }
    }
}