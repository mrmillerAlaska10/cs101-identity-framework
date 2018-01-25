using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.ViewModels.StudentViewModels
{
    public class GradeViewModel
    {
        public int StudentId { get; set; }
        public ICollection<Grade> grade { get; set; }
    }
}
