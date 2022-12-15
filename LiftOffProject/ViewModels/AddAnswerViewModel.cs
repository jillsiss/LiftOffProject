using LiftOffProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace LiftOffProject.ViewModels
{
    public class AddAnswerViewModel
    {
        //public int QuizId { get; set; }
        //public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }
        public bool IsAnswer { get; set; }
        public bool IsChosen { get; set; }
        public List<SelectListItem> Choice { get; set; }



        public AddAnswerViewModel(List<Answers> answers)
        {
            Choice = new List<SelectListItem>();
            
            foreach (var answer in answers)
                {
                Choice.Add(
                    new SelectListItem
                    {
                        Text = answer.Choice,
                        Value = answer.AnswerId.ToString()
                    }
                    );
                }
        }

        public AddAnswerViewModel()
        {
        }
    }
}
