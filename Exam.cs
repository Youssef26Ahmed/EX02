using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public abstract class Exam 
    {
        public int time { get; set; }
        public int numberofQuestions { get; set; }
        public List<Question> questions { get; set; }
        public Exam(int time, int numberofQuestions, List<Question> questions)
        {
            this.time = time;
            this.numberofQuestions = numberofQuestions;
            this.questions = questions;
        }
     
        public abstract void showExam();
    
    }
}
