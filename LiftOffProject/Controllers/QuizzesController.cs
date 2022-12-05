using System;
using System.Collections.Generic;
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

                return Redirect("Index");
            }

            return View(addQuizViewModel);
        }
    }
}
