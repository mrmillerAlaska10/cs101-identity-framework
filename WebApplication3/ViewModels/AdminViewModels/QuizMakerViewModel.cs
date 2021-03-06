﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.ViewModels.AdminViewModels
{
    public class QuizMakerViewModel
    {

        public int LessonNumber { get; set; }
        public int QuizNumber { get; set; }
        public string QuizName { get; set; }
        public string[] Question { get; set; }
        public string[] Answer { get; set; }
        public string[] MCOptions { get; set; }
    }
}
