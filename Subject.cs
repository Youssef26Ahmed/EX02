using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Subjectexam { get; set; }

        public Subject(int id, string name)
        {
            SubjectId = id;
            SubjectName = name;
        }

        public void CreateExam()
        {
            Console.WriteLine(
                "please Enter the type of Exam you want to create  ( 1 for  practical  and 2 for Final ) "
            );
            int type = int.Parse(Console.ReadLine());
            if (type == 1)
            {
                Console.WriteLine("please Enter the time of the Exam  in Munites ");
                int time = int.Parse(Console.ReadLine());
                Console.WriteLine("please Enter the number of Questions ");
                int num = int.Parse(Console.ReadLine());
                List<Question> questions = new List<Question>();
                Answer[] answer = new Answer[4];
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("please Enter the Question Body ");
                    string body = Console.ReadLine();

                    Console.WriteLine("Please enter the marks of the question");
                    int marks = int.Parse(Console.ReadLine());

                    Console.WriteLine("please Enter the Question Answers ");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.WriteLine($"please Enter choice {j + 1} ");
                        string ans = Console.ReadLine();
                        answer[j] = new Answer(j+1, ans);
                    }

                    Console.WriteLine("please Enter the number of the right choice ");
                    int rightAnswer = int.Parse(Console.ReadLine());
                    Question q = new MCQ("MCQ", body, marks, answer, answer[rightAnswer - 1]);
                    questions.Add(q);

                    Exam paricticalExam = new PracticalExam(time, num, questions);

                    Subjectexam = paricticalExam;
                }
            }
            else if (type == 2)
            {
                Console.WriteLine("please Enter the time of the Exam  in Munites ");
                int time = int.Parse(Console.ReadLine());
                Console.WriteLine("please Enter the number of Questions ");
                int num2 = int.Parse(Console.ReadLine());
                List<Question> questions = new List<Question>();
                int iterator = num2;
                while (iterator > 0)
                {
                    Console.WriteLine(
                        "please enter the type of the question ( 1 for True or False  2 for MCQ )"
                    );

                    int qtype = int.Parse(Console.ReadLine());
                    if (qtype == 1)
                    {
                        Answer[] answer =  { new Answer(1, "True"), new Answer(2,"False") };
                        Console.WriteLine("please Enter the Question Body ");
                        string body = Console.ReadLine();
                        Console.WriteLine("Please enter the marks of the question");
                        int marks = int.Parse(Console.ReadLine());
                        
                        Console.WriteLine("please Enter the number of the right choice ");
                        int rightAnswer = int.Parse(Console.ReadLine());
                        Question q = new TrueOrFalse(
                            "TrueOrFalse",
                            body,
                            marks,
                            answer,
                            answer[rightAnswer-1]
                        );
                        questions.Add(q);
                        iterator--;

                    }
                    else if (qtype == 2)
                    {
                        Answer[] answer = new Answer[4];
                        
                            Console.WriteLine("please Enter the Question Body ");
                            string body = Console.ReadLine();

                            Console.WriteLine("Please enter the marks of the question");
                            int marks = int.Parse(Console.ReadLine());

                            Console.WriteLine("please Enter the Question Answers ");
                            for (int j = 0; j < 4; j++)
                            {
                                Console.WriteLine($"please Enter choice {j + 1} ");
                                string ans = Console.ReadLine();
                                answer[j] = new Answer(j+1, ans);
                            }

                            Console.WriteLine("please Enter the number of the right choice ");
                            int rightAnswer = int.Parse(Console.ReadLine());
                            Question q = new MCQ(
                                "MCQ",
                                body,
                                marks,
                                answer,
                                answer[rightAnswer - 1]
                            );
                            questions.Add(q);
                            iterator--;
                        
                       
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                  
                }
                Exam FinalExam = new FinalExam(time, num2, questions);

                Subjectexam = FinalExam;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        public override string ToString()
        {
            return SubjectName + "\t" + SubjectId;
        }
    }
}
