using System.Collections;
using System.Collections.Generic;

namespace LiftOffProject.Models
{
    public class Answers
    {
        public int Id { get; set; }
        public bool IsAnswer { get; set; }
        public bool IsChosen { get; set; }
        //public Question Question { get; set; }
        public string Choice { get; set; }   //Do we need this?//
        public string Text { get; set; }


        public Answers(bool isAnswer, bool isChosen, /*Question question, */string choice, string text)
        {
            //Question = question;
            IsAnswer = isAnswer;
            IsChosen = isChosen;
            Choice = choice;//Do we need this?//
            Text = text;
        }
        
        public Answers()
        {
        }
    }
}
