﻿using System;
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
        public int QuizNumber { get; set; }
        public int LessonID { get; set; }
        public int LessonNumber { get; set; }

        public ICollection<QuizQuestion> QuizQuestions { get; set; }
    }
}
