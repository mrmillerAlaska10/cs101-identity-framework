using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models.QuizModels
{
    public class QuizModel
    {
        [Required]
        public int Id { get; set; }
        [Required]       
        public string QuizName { get; set; }

        [Required]      
        public string Answer { get; set; }

       
    }
}
