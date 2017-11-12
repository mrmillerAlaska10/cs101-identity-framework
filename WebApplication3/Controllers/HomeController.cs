using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private WebApplication3.Data.ApplicationDbContext db;

        public HomeController(WebApplication3.Data.ApplicationDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {

            //db.Users.AddRange(new ApplicationUser { Email = "g@myemail.com", UserName = "bob sagget" });
            //     ViewData["user"] = db.Users.Last();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
