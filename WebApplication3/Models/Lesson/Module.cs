using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models.Lesson
{
    
    public class Module
    {
        [Key]
        int ModuleID;
        public string ModuleTitle { get; set; }
        public string[] Lesson { get; set; }
    }
}
