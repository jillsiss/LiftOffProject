using LiftOffProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace LiftOffProject.ViewModels
{
    public class QuizViewModel
    {
        public int QuizId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Published  { get; set; }
        public List<Question> Questions { get; set; }
        


        public QuizViewModel(Quiz theQuiz)
        {
            QuizId = theQuiz.QuizId;
            Title = theQuiz.Title;
            Author = theQuiz.Author;
            Published = theQuiz.Published;
            Questions = theQuiz.Questions;
        }

        public QuizViewModel()
        {
        }
    }
}
