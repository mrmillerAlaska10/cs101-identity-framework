using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models.ModuleModels
{
    
    public class Module
    {
        [Key]
        public int ModuleID { get; set; }
        public string ModuleTitle { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
