using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models.QuizModels
{
    public class QuizQuestion
    {
        [Key]
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int QuizID { get; set; }
    }
}
