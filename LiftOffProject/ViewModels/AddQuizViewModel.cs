using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using LiftOffProject.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LiftOffProject.ViewModels
{
    public class AddQuizViewModel
    {
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }

        public DateTime Published { get; set; }

        public List<Question> Questions { get; set; }
        public AddQuizViewModel()
        {

        }
    }
}
