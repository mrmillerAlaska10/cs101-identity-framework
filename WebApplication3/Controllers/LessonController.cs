using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication3.Controllers
{
    public class LessonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Lesson(int id)
        {
            return View();
        }
    }
}