using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_system
{
    internal class Final :Exam
    {
        public Final(int _time ,int _numofQ)
        {
            Time= _time;    
            QuestionNum= _numofQ;   

        }
        public Final()
        {

        }

        public void ChoiseQuestionType()
        {
            int num;
            bool flag;
            do 
            {
                Console.WriteLine("please choise question type(1.TF | 2.MCQ) : ");
                flag = int.TryParse(Console.ReadLine(), out num ); 
            } while(!flag);
            if (num == 1)
            {
                TrueFalse x = new TrueFalse();
                x.EnterQuestion();  
            }
            else if (num == 2) 
            {
                MCQ y= new MCQ();
                y.EnterQuestion();  
            }
            else 
            {
                do
                {
                    Console.WriteLine("please choise question type(1.TF | 2.MCQ) : ");
                    flag = int.TryParse(Console.ReadLine(), out num);
                } while (!flag);

            }
        }
    }
}
