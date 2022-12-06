using System.Collections;

namespace LiftOffProject.Models
{
    public class Answers
    {
        public int Id { get; set; }
        public bool IsAnswer { get; set; }
        public bool IsSelected { get; set; }
        public Question Question { get; set; }
        public string Choice { get; set; }

        public Answers(bool isAnswer, bool isSelected, Question question, string choice)
        {
            Question = question;
            IsAnswer = isAnswer;
            IsSelected = isSelected;
            Choice = choice;

        }

        public Answers()
        {
             
        }
    }
}
