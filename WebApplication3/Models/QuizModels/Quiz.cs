using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models.QuizModels
{
    public class Quiz
    {
        public int QuizId { get; set; }
        public string QuizName { get; set; }
        public string[] Question { get; set; }
        public string[] Answer { get; set; }
        public string[] MCOptions { get; set; }

        public ICollection<QuizQuestion> QuizQuestions { get; set; }
    }
}
