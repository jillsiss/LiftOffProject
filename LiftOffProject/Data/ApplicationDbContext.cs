using LiftOffProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiftOffProject.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Quiz> Quizzes { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<Answers> Answers { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
