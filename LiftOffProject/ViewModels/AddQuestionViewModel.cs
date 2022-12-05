using LiftOffProject.Data;
using System.ComponentModel.DataAnnotations;

namespace LiftOffProject.ViewModels
{
    public class AddQuestionViewModel
    {
        [Required]
        public string Query { get; set; }
        
    }
}
