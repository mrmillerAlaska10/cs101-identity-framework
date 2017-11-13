using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;
using WebApplication3.Models.QuizModels;

namespace WebApplication3.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        
        public ApplicationDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) // hardcode in connection to database through this context.
        {
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CS101;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(builder);
        }
        public DbSet<QuizQuestion> QuizQuestions { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }


    }

    public static class DbContextExtensions
    {
        public static void Seed(this ApplicationDbContext context)
        {
            // Perform database delete and create
           // context.Database.EnsureDeleted();
          //  context.Database.EnsureCreated();

            // Perform seed operations
           // AddRoles(context);

            // Save changes and release resources
           // context.SaveChanges();
          //  context.Dispose();
        }

        private static void AddRoles(ApplicationDbContext context)
        {
            context.AddRange(
                new IdentityRole {Name = "user" },
                 new IdentityRole { Name = "admin" }
                );
            context.AddRange(
                new ApplicationUser { Email = "admin@myemail.com", UserName = "admin" },
                 new ApplicationUser { Email = "admin@myemail.com", UserName = "bob saget" }
            );
           

            Console.WriteLine("\n\n\nbatman\n\n\n");
        }

    }
}
