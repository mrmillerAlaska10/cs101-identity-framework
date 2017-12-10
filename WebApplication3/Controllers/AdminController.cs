using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models.QuizModels;
using WebApplication3.Models.ModuleModels;
using WebApplication3.Models;
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
            Module module = new Module { ModuleTitle = model.ModuleTitle, CourseID = model.CourseID, ModuleNumber = model.ModuleNumber };
            Course course;
            using (var context = new ApplicationDbContext())
            {
                // Query for all blogs with names starting with B 
                //var c = from b in context.Courses
                //            where b.CourseId == module.CourseID
                //            select b ;
                var d = context.Courses.Where(b => b.CourseId == model.CourseID).FirstOrDefault();
                course = d;
            }
            //course.Modules.Add(module);

            db.Entry(course).State = EntityState.Modified; // updates entitiy in database
            db.Add(module);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CourseMaker()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CourseMaker(CourseMakerViewModel model)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            Course module = new Course { ClassSize = model.ClassSize, ClassLimit = model.ClassLimit, CourseName = model.CourseName, InstructorName = model.InstructorName };

            db.Add(module);
            db.SaveChanges();
            return RedirectToAction("Index");
            //return View(model);
        }

        [HttpGet]
        public IActionResult QuizMaker()
        {
            return View();
        }

        [HttpPost]
        public IActionResult QuizMaker(QuizMakerViewModel model)
        {
            ApplicationDbContext db = new ApplicationDbContext();
            int Counter = 0;
            int id = 0;
            int lesID;
            using (db) { lesID = db.Lessons.Where(b => b.LessonNumber == model.LessonNumber).FirstOrDefault().LessonID; }
            Quiz quiz = new Quiz { QuizName = model.QuizName, LessonID = lesID };

            using (db)
            {
                if (db.Quizzes.Last().QuizId != 0)
                    id = db.Quizzes.Last().QuizId + 1;
                else
                    id = 1;
            }

            foreach ( var question in model.Question)
            {
                QuizQuestion temp = new QuizQuestion { Question = model.Question[Counter], Answer = model.Answer[Counter], QuizID = id };
                quiz.QuizQuestions.Add(temp);
                db.Add(temp);
                Counter++;
            }
            db.Quizzes.Add(quiz);
            db.SaveChanges(); // maybe change to async
            //return View(model);
            return RedirectToAction("Index");
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
            Lesson lesson = new Lesson { LessonTitle = model.LessonTitle, LessonText = model.LessonText, LessonNumber = model.LessonNumber, ModuleNumber = model.ModuleNumber };
            Module module;
            using (db) { module = db.Modules.Where(b => b.ModuleNumber == lesson.ModuleNumber).FirstOrDefault(); }
            module.Lessons.Add(lesson);
            db.Lessons.Add(lesson);
            db.SaveChanges();
            return View(model);
        }

        public IActionResult StudentGrades()
        {
            var entities = new ApplicationDbContext();
            System.Console.WriteLine(entities.Students.ToList());
            return View(entities.Students.ToList());
        }


    }
}