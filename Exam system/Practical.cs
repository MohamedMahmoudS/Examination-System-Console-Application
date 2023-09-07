using Exam_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_system
{
    internal class Practical :Exam
    {
        public Practical(int _time, int _numofQ)
        {
            Time = _time;
            QuestionNum = _numofQ;

        }
        
    }
}
