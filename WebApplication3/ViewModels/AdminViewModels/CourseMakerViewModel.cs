using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.ViewModels.AdminViewModels
{
    public class CourseMakerViewModel
    {
        public int CourseId { get; set; }
        public int ClassSize { get; set; }
        public int ClassLimit { get; set; }
        public string CourseName { get; set; }
        public string InstructorName { get; set; }
    }
}
