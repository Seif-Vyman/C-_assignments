using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal abstract class Question
    {
        public int Id { get; set; }
        public string? Header { get; set; }
        public string?  Body { get; set; }
        public int Mark { get; set; }
        public List<Answer> Answers { get; set; }
        public int RightAnswerId { get; set; }

        public Question(){}

        public Question(int id, string header, string body, int mark)
        {
            Id = id;
            Header = header;
            Body = body;
            Mark = mark;
        }

        public int IsCorrect(int answerId)
        {
            return RightAnswerId == answerId? Mark : 0;
        }
        #region override

        public override string ToString()
        {
            return $"Question Id: {Id}, Question Header: {Header}, Question Body: {Body}, Question Mark: {Mark}";
        }

        #endregion

    }
}
