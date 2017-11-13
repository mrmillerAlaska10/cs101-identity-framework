using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models.QuizModels;
using WebApplication3.Models.ModuleModels;
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

        [HttpGet]
        public IActionResult ModuleMaker()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ModuleMaker(ModuleMakerViewModel model)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Module module = new Module { ModuleTitle = model.ModuleTitle };

            db.Add(module);
            db.SaveChanges();
            return View(model);
        }

        [HttpGet]
        public IActionResult QuizMaker()
        {
            return View();
        }

        [HttpPost]
        public IActionResult QuizMaker(QuizMakerViewModel model)
        {
            int Counter = 0;
            ApplicationDbContext db = new ApplicationDbContext();
            var quiz = new Quiz { QuizName = model.QuizName };

            foreach ( var question in model.Question)
            {
                QuizQuestion temp = new QuizQuestion { Question = model.Question[Counter], Answer = model.Answer[Counter] };
                db.Add(temp);
                Counter++;
            }
            db.Quizzes.Add(quiz);
            db.SaveChanges(); // maybe change to async
            return View(model);
        }

        [HttpGet]
        public IActionResult LessonMaker()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LessonMaker(LessonMakerViewModel model)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Lesson lesson = new Lesson { LessonTitle = model.LessonTitle, LessonText = model.LessonText };

            db.Lessons.Add(lesson);
            db.SaveChanges();
            return View(model);
        }

        public IActionResult StudentGrades()
        {
            return View();
        }
    }
}