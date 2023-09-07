using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_system
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam ExamType { get; set; }

        public Subject(int Id, string Name)
        {
            SubjectId = Id;
            SubjectName = Name;

        }

        public void CreateExam()
        {
            int time,questionNum, Type;
            bool flag;
            do
            {
                Console.WriteLine("please choise exam type (1.final | 2.practical)");
                flag=int.TryParse(Console.ReadLine(), out Type);
            }
            while (!flag);
            do
            {
                Console.WriteLine("please enter exam time : ");
               flag= int.TryParse(Console.ReadLine(), out time );
            }
            while (!flag);
            do
            {
                Console.WriteLine("please enter number of question : ");
                flag = int.TryParse(Console.ReadLine(), out questionNum);
            }
            while (!flag);
            if (Type == 1)
            {
                Final final = new Final(time, questionNum);
                final.ChoiseQuestionType();
            }
            else if (Type == 2)
            {
                Practical practical = new Practical(time, questionNum);  
            }
            else 
            {
                do
                {
                    Console.WriteLine("please choise exam type (1.final | 2.practical)");
                    int.TryParse(Console.ReadLine(), out Type);
                }
                while (!(int.TryParse(Console.ReadLine(), out Type)));
            }
        }

    }
}
