using LiftOffProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace LiftOffProject.ViewModels
{
    public class AddAnswerViewModel
    {
        public int QuizId { get; set; }
        public int QuestionId { get; set; }
        public List<SelectListItem> Choice { get; set; }



        public AddAnswerViewModel(Quiz theQuiz, Question theQuestion)
        {
            Choice = new List<SelectListItem>();
            Answers answers = new Answers();

            //Choice.Add(answers);
        }

        public AddAnswerViewModel()
        {
        }
    }
}
