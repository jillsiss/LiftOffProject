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

        public Answers()
        {
        }
    }
}
