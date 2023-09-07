using Exam_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Exam_system
{
    internal class MCQ :Question
    {
        public MCQ()
        {          
        }
        public override void EnterQuestion()
        {
            Header = "MCQ Question";
            Console.WriteLine("please enter question body : ");
            string x = Console.ReadLine();
            AnswerList = new Answer[3];
            for (int i = 0; i < 3; i++)
            {
                AnswerList[i] = new Answer();
            }
            Console.WriteLine("enter the rigth answer : ");
            RightAnswer = new Answer();

        }

        public override string ToString()
        {
            return $"{Header}\tMark({Mark})\n{Body}\n{AnswerList[0]}\t\t\t{AnswerList[1]}\t\t\t{AnswerList[2]}\n----------------------------------------------";
        }
    }
}


