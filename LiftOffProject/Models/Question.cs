using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace LiftOffProject.Models
{
    public class Question
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public string Query { get; set; }
        public string AnswerOne { get; set; }
        public string AnswerTwo { get; set; }
        public string CorrectAnswer { get; set; }
        public List<Answers> ChosenAnswers { get; set; }
        public List<Answers> CorrectAnswers { get; set; }


        public Question(string query, string answerOne, string answerTwo, string correctAnswer)
        {
            Query = query;
            AnswerOne = answerOne;
            AnswerTwo = answerTwo;
            CorrectAnswer = correctAnswer;
        }

        public Question()
        {
        }
        
    }
}
