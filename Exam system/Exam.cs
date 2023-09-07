using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_system
{
    internal class Exam :ICloneable
    {
        public int Time { get; set; }
        public int QuestionNum { get; set; }
        public Question[] Question { get; set; }

        public virtual  void ShowExam()
        {
            
        }
        public object Clone()
        {
            return new Exam()
            {
                Question = new Question[this.QuestionNum],
                QuestionNum = this.QuestionNum,
                Time = this.Time
            };

        }
    }
}
