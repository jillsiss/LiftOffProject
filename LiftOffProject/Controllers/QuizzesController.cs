using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading.Tasks;
using LiftOffProject.Data;
using LiftOffProject.Models;
using LiftOffProject.ViewModels;
//using LiftOffProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace LiftOffProject.Controllers
{
    public class QuizzesController : Controller
    {
        private ApplicationDbContext context;

        public QuizzesController(ApplicationDbContext dbContext)
        {
            context = dbContext;
        }


        public IActionResult Index()
        {
            List<Quiz> quizzes = context.Quizzes
                .ToList();
            return View(quizzes);
        }

        public IActionResult Add()
        {
            AddQuizViewModel addQuizViewModel = new AddQuizViewModel();
            return View(addQuizViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddQuizViewModel addQuizViewModel)
        {
            if (ModelState.IsValid)
            {
                Quiz newQuiz = new Quiz
                {
                    Title = addQuizViewModel.Title,
                    Author = addQuizViewModel.Author,
                    Published = DateTime.Now
                };

                context.Quizzes.Add(newQuiz);
                context.SaveChanges();

                return Redirect("AddQuestions/" + newQuiz.Id);
            }

            return View(addQuizViewModel);
        }

        public IActionResult AddQuestions(int quizId)
        {
            Quiz quiz = context.Quizzes.Find(quizId);
            AddQuestionViewModel addQuestionViewModel = new AddQuestionViewModel();
            return View(addQuestionViewModel);
        }

        [HttpPost]
        public IActionResult AddQuestions(AddQuestionViewModel addQuestionViewModel)
        {
            if (ModelState.IsValid)
            {
                //List<Answers> theAnswers = new List<Answers>();

                //foreach (var answer in addQuestionViewModel.Answers)
                //{
                //    // this foreach loop iterates over the SelectListItem objects and converts them into Answer objects
                //    Answers newAnswer = new Answers();
                //    if (answer.Selected)
                //    {
                //        newAnswer.IsAnswer = true;
                //    }

                //    newAnswer.Text = answer.Value;

                //    theAnswers.Add(newAnswer);
                //};

                Question newQuestion = new Question
                {
                    Query = addQuestionViewModel.Query,
                    AnswerOne = addQuestionViewModel.AnswerOne,
                    AnswerTwo = addQuestionViewModel.AnswerTwo,
                    CorrectAnswer = addQuestionViewModel.CorrectAnswer,
                };
            

                context.Questions.Add(newQuestion);

                context.SaveChanges();

            }
            return View(addQuestionViewModel);
        }
   

        //    return Redirect("Index");
        //}

        [HttpGet]
        [Route("/quizzes/quiz/{quizId}")]
        public IActionResult Quiz(int quizId)
        {
            Quiz theQuiz = context.Quizzes
                .Find(quizId);

            QuizViewModel quizViewModel = new QuizViewModel(theQuiz);
            return View(quizViewModel);

        }

        [HttpPost]
        [Route("/quizzes/quiz/{quizId}")]
        public IActionResult Quiz(int quizId, string title, string author)
        {
            
            Quiz theQuiz = context.Quizzes
                .Find(quizId);


            theQuiz.Title = title;
            theQuiz.Author = author;

            context.SaveChanges();

            return Redirect("/Quizzes");
        }

        [HttpGet]
        [Route("/quizzes/delete/{quizId}")]
        public IActionResult Delete(int quizId)
        {
            Quiz theQuiz = context.Quizzes
                .Find(quizId);

            QuizViewModel quizViewModel = new QuizViewModel(theQuiz);
            return View(quizViewModel);
        }


        [HttpPost]
        [Route("/quizzes/delete/{quizId}")]
        public IActionResult Confirm(int quizId)
        {
            Quiz theQuiz = context.Quizzes.Find(quizId);
            context.Quizzes.Remove(theQuiz);

            context.SaveChanges();
            return Redirect("/Quizzes");
        }
    }
};

