using LiftOffProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LiftOffProject.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IList<Question> GetQuestions()
        {
            var questions = new List<Question>()
                {
                    new Question() { Query = "What is 2+2", Point = 10, Id = 1},
                    new Question() { Query = "What is 5+2", Point = 10, Id = 2}

                };

            //questions[0].AddChoice(new Answers() { IsAnswer = false, Choice = "2", Id = 1 });
            //questions[0].AddChoice(new Answers() { IsAnswer = true, Choice = "4", Id = 2 });
            //questions[1].AddChoice(new Answers() { IsAnswer = false, Choice = "12", Id = 3 });
            //questions[1].AddChoice(new Answers() { IsAnswer = true, Choice = "7", Id = 4 });


            return questions;

        }
    }
}
