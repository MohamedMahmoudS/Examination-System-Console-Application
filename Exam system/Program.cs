using System.Diagnostics;

namespace Exam_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject s01 = new Subject(10, "c#");
            s01.CreateExam();
            Console.Clear();
            Console.WriteLine("do you want to start the exam (y|n):");
            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                s01.ExamType.ShowExam();    
                Console.WriteLine($"the elapsed time ={sw.Elapsed}");
            }
        }
    }
}