using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data;
using WebApplication3.Models.ModuleModels;

namespace WebApplication3.ViewComponents
{
    public class SideBarViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext db;

        public SideBarViewComponent(ApplicationDbContext context)
        {
            db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetModules();
            return View(items);
        }

        private Task<List<Module>> GetModules()
        {
            return db.Modules.ToListAsync();
        }
    }
}
