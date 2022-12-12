using System.Collections;
using System.Collections.Generic;

namespace LiftOffProject.Models
{
    public class Answers
    {
        public int Id { get; set; }
        public bool IsAnswer { get; set; }
        public bool IsSelected { get; set; }
        public Question Question { get; set; }
        public string Choice { get; set; }   //Do we need this?//
        public bool CorrectAnswers { get; set; }
        public List<Answers> ChosenAnswers { get; set; }

        public Answers(bool isAnswer, bool isSelected, Question question, string choice, List<Answers> correctAnswers, List<Answers> chosenAnswers)
        {
            Question = question;
            IsAnswer = isAnswer;
            IsSelected = isSelected;
            Choice = choice;//Do we need this?//
            CorrectAnswers = correctAnswers;
            ChosenAnswers = chosenAnswers;
        }
        
        public Answers()
        {
            Answers answer = new Answers();
            if (answer.IsAnswer == true)
            {
                CorrectAnswers.Add(answer);
            }
            

            if (answer.IsSelected == true)
            {
                ChosenAnswers.Add(answer);
            }
            return;
        }
    }
}
