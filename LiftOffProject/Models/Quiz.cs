using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace LiftOffProject.Models
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Published { get; set; }
        public List<Question> Questions { get; set; }
        //public int TotalPoints { get; set; }



        public Quiz()
        {
        }

    }
}
