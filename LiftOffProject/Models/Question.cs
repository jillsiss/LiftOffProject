using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace LiftOffProject.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public string Query { get; set; }
        public List<Answers> Answers { get; set; }
        public List<Answers> ChosenAnswers { get; set; }
        public List<Answers> CorrectAnsers { get; set; }


        public Question(string query, List<Answers> answers)
        {
            Query = query;
            Answers = answers;
        }

        public Question()
        {
        }
        
    }
}
