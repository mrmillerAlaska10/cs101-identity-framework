using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public int ClassSize { get; set; }
        public int ClassLimit { get; set; }
        //meeting time
        //other variables
        public string CourseName { get; set; }
        public string InstructorName { get; set; }

    }
}
