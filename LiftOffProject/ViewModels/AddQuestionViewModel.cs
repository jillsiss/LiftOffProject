using LiftOffProject.Data;
using LiftOffProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LiftOffProject.ViewModels
{
    public class AddQuestionViewModel
    {
        public int QuizId { get; set; }
        public int QuestionId { get; set; }
        [Required(ErrorMessage = "Question is required.")]
        public string Query { get; set; }
        public List<SelectListItem> Answers { get; set; }

        public List<Answers> CorrectAnswers { get; set; }
        public List<Answers> ChosenAnswers { get; set; }
        

        //public AddQuestionViewModel(Quiz quiz)
        //{
        //    QuizId = quiz.Id;
        //}
        public AddQuestionViewModel(Quiz quiz, List<Answers> answers)
        {
            QuizId = quiz.Id;

            foreach (var answer in answers)
            {
                Answers.Add(new SelectListItem
                {
                    Value = answer.Id.ToString(),
                    Text = answer.Choice
                });
            }
        }

        public AddQuestionViewModel()
        {
        }
        
        public void AddFields()
        {

        }
    }

}
