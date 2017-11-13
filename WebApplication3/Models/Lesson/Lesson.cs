using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models.Lesson
{
    public class Lesson
    {
        [Key]
        public int LessonID { get; set; }
        public string LessonTitle { get; set; }
        public string LessonText { get; set; }//unformated. Format in js
    }
}
