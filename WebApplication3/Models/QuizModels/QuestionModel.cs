using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models.QuizModels
{
    public class QuestionModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Question { get; set; }

        [Required]
        public string Answer { get; set; }

        public int QuizFK { get; set; }

        [ForeignKey("QuizFK")]
        public QuizModel QuizModel { get; set; }
    }
}
