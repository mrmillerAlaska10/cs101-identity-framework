using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models.ModuleModels
{
    public class StudentModuleModel
    {   [Key]
        public int relationID { get; set; }

        public int StudentID { get; set; }
        public Student student { get; set; }

        public int ModuleID { get; set; }
        public Module module{ get; set; }
    }
}
