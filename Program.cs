using System.Diagnostics;
using Exam02;

internal class Program
{
    private static void Main(string[] args)
    {
        

        Subject programming = new Subject(101, "programming");
        programming.CreateExam();
        Console.Clear();
        Console.WriteLine("Do you want to start the Exam ? (y/n)");
        if(Console.ReadLine().ToLower() == "y")
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            programming.Subjectexam.showExam();

            stopwatch.Stop();
            Console.WriteLine("Time taken: " + stopwatch.Elapsed);
        }
        else
        {
            Console.WriteLine("Goodbye");
        }

    }
}