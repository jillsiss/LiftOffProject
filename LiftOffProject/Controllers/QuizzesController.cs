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
            return View(quiz);
        }

        [HttpPost]
        public IActionResult AddQuestions(AddQuestionViewModel addQuestionViewModel, AddAnswerViewModel addAnswerViewModel)
        {
            if (ModelState.IsValid)
            {
                List<Answers> theAnswers = new List<Answers>();
                foreach (var answer in addQuestionViewModel.Answers)
                    {


                    Answers newAnswers = new Answers
                    {
                        IsAnswer = addQuestionViewModel.Answers.Contains(answer),
                        IsSelected = addQuestionViewModel.Answers.Contains(answer),
                       
                    };
                    }
                
                Question newQuestion = new Question
                {
                    Query = addQuestionViewModel.Query,
                    Answers = theAnswers,
                    
                    

                    //Answers = new List<Answers>
                    

                    
                };
                
                
                context.Questions.Add(newQuestion);
                context.SaveChanges();
                return View(addQuestionViewModel);
                
            }


            return Redirect("Index");
        }

        public IActionResult Quiz(int id)
        {
            Quiz theQuiz = context.Quizzes
                .Find(id);

            QuizViewModel quizViewModel = new QuizViewModel(theQuiz);
            return View(quizViewModel);

        }
    }
}
