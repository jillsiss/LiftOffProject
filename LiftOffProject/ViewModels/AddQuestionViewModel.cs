using LiftOffProject.Data;
using LiftOffProject.Models;
using Microsoft.AspNetCore.Mvc;
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
        public List<Answers> Answers { get; set; }

        public AddQuestionViewModel()
        {
            Answers = new List<Answers>();
        }

        
    }

}
