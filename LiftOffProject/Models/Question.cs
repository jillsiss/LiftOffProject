using System.Collections.Generic;

namespace LiftOffProject.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public string Query { get; set; }
        public List<Answers> Answers { get; set; }
        public int Point { get; set; }


        public Question(string query, List<Answers> answers, int point)
        {
            Query = query;
            Answers = answers;
            Point = point;
        }

        public Question()
        {
        }
        
    }
}
