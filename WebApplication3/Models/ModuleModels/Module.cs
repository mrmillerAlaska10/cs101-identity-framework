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
        public int ModuleNumber { get; set; }
        public string ModuleTitle { get; set; }
        public int CourseID { get; set; }
        public ICollection<Lesson> Lessons { get; set; }

        public int GetCompletion(int studentID) { return 0; }
        public int AddCompletion(int studentID, int percent) { return 0; }

        public virtual ICollection<StudentModuleModel> Students { get; set; }
    }
}
