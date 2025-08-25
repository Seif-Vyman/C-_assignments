using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(int id, string header, string body, int mark, List<Answer> answers,int rightAnswerId) : base(id, header, body, mark) 
        {
            Answers = answers;
            RightAnswerId = rightAnswerId;
        }

       
    }
}
