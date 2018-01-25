using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Grade
    {
        [Key]
        public int GradeId { get; set; }
        public int StudentId { get; set; }
        public int LessonId { get; set; }
        public int grade { get; set; }
    }
}
