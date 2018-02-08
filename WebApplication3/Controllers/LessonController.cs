using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Models.ModuleModels;
namespace WebApplication3.Controllers
{
    public class LessonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Module(int id)
        {           

            var entities = new ApplicationDbContext();

            ViewData["Module"] = entities.Modules.Where(mdle => mdle.ModuleID == id);
            ViewData["Lessons"] = entities.Lessons.Where(ls => ls.ModuleId == id).ToList();


            System.Console.WriteLine(entities.Lessons.ToString());
            return View();
        }
    }
}