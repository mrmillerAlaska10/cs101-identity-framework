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
            db.Add(quiz);
            db.SaveChanges(); // maybe change to async
            return View(model);
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