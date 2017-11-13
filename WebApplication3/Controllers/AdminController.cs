using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models.QuizModels;
using WebApplication3.ViewModels.AdminViewModels;
using WebApplication3.Data;


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

        public IActionResult QuizMaker(QuizMakerViewModel model)
        {
            //ApplicationDbContext db = new ApplicationDbContext();
            //var quiz = new Quiz { Question = model.Question, Answer = model.Answer, MCOptions = model.MCOptions };

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