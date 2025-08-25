using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Answer
    {
        public int AnswerId { get; set; }
        public string? AnswerText { get; set; }


        public Answer(int answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }
        

       
        #region override

        public override string ToString()
        {
            return $"Answer Id: {AnswerId}, Answer Text: {AnswerText}";
        }

        #endregion
    }
}
