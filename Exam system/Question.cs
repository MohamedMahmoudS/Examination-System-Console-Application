using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_system
{

    internal class Question : ICloneable
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }
        

        public Question()
        {

        }

        public virtual void EnterQuestion()
        { 
        }
        public object Clone()
        {
            return new Question()
            {
                AnswerList = this.AnswerList,
                RightAnswer = new Answer()
                {
                    AnswerText = string.Empty,
                },

                Body = this.Body,
                Header = this.Header


            };

        }
    }
}
