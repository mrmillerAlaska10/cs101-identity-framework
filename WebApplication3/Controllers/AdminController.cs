using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ModuleMaker()
        {
            return View();
        }

        public IActionResult QuizMaker()
        {
            return View();
        }

        public IActionResult LessonMaker()
        {
            return View();
        }

        public IActionResult StudentGrades()
        {
            return View();
        }
    }
}