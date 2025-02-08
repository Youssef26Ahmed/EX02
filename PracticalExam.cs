using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int time, int numberofQuestions, List<Question> questions) : base(time, numberofQuestions, questions)
        {
        }

        public override void showExam()
        {
            Console.WriteLine("Practical Exam");
            Console.WriteLine("Time: " + time);
            Console.WriteLine("Number of Questions: " + numberofQuestions);
            Console.WriteLine("Questions: ");
            int[] correctchoisces = new int[numberofQuestions];
            int counter = 0;
            foreach (var q in questions)
            {
                Console.WriteLine(q.Header + "\t" + $"Marks({q.Mark})");
                Console.WriteLine();
                Console.WriteLine(q.Body);
                Console.WriteLine();
                Console.WriteLine("Answers: ");
                foreach (var answers in q.Answers)
                {
                    Console.Write(answers.AnswerId  + "." + answers.AnswerText + "\t");


                    

                }
                Console.WriteLine("\nPlease choose the correct answer");
                int choice = int.Parse(Console.ReadLine());
           
                if (choice ==q.RightAnswer.AnswerId)
                {
                    correctchoisces[counter] = 1;
                    counter++;
                }
                else
                {
                    correctchoisces[counter] = 0;
                    counter++;

                }

                Console.WriteLine("-------------------------------------------------------------------------------------------");
            }

            Console.WriteLine("Your Score is: " + correctchoisces.Sum() + "/" + numberofQuestions);
        }
    }
}
