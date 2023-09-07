using Exam_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_system
{
    internal class TrueFalse :Question
    {
        public TrueFalse()
        {
            Header = "True | False Question";
            AnswerList = new[]
            {
                new Answer()
                {
                    AnswerText = "True",
                    AnswerId = 1
                },
                new Answer()
                {
                    AnswerText = "False",
                    AnswerId = 2
                }
            };
            RightAnswer = new Answer();
        }
        public override void EnterQuestion()
        {
            Console.WriteLine("please enter question body : ");
            string x = Console.ReadLine();
            Console.WriteLine("enter the rigth answer (1.true | 2.false)");
            int y = int.Parse(Console.ReadLine());

        }
        

        public override string ToString()
        {
            return $"{Header}\tMark({Mark})\n{Body}\n{AnswerList[0]}\t\t\t{AnswerList[1]}\n----------------------------------------------";
        }

    }
}


