using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class Subject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public Exam? exam { get; set; }

        public Subject(){}

        public Subject(int id, string? name)
        {
            Id = id;
            Name = name;
        }

        public void CreateExam(Exam _exam)
        {
            exam = _exam;
            exam.subject = this;
        }
        #region override

        public override string ToString()
        {
            return $"SUbject IdL {Id}, Subject Name: {Name}";
        }

        #endregion
    }
}
