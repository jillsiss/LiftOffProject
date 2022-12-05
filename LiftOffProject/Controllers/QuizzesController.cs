using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiftOffProject.Data;
using LiftOffProject.Models;
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
    }
}
