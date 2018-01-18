using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ViewModels.StudentViewModels
{
    public class EnrollViewModel
    {
        public IEnumerable<Course> Locations { get; set; }
        public Course Location { get; set; }
    }
}
