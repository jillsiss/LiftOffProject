using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace LiftOffProject.Models
{
    public class Quiz
    {
        public int QuizId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Published { get; set; }
        public List<Question> Questions { get; set; }
        public int TotalPoints { get; set; }



        public Quiz(string title, string author, DateTime published, List<Question> questions)
        {
            Title = title; 
            Author = author;
            Published = published;
            Questions = questions;
        }
        public Quiz(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public Quiz()
        {
        }

    }
}
