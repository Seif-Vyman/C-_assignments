using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(int id, string header, string body, int mark, bool rightAnswer) : base(id, header, body, mark)
        {
            Answers = new List<Answer>()
            {
                new Answer(1,"True"),
                new Answer(2,"False")
            };
            RightAnswerId = rightAnswer ? 1 : 2;
        }



    }
}
