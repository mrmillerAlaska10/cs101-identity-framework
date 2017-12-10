using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models.QuizModels;

namespace WebApplication3.Models.ModuleModels
{
    public class Lesson
    {
        [Key]
        public int LessonID { get; set; }
        public int ModuleNumber { get; set; }
        public int LessonNumber { get; set; } // helps differentiate between lessons inside of each module
        public string LessonTitle { get; set; }
        public string LessonText { get; set; }//unformated. Format in js
    }
}
