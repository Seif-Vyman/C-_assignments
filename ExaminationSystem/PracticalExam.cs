using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(TimeSpan duration, int numberofQuestions, Subject _subject) : base(duration, numberofQuestions, _subject)
        {

        }

        public override void StartExam()
        {
            Console.WriteLine($"Practical Exam for subject: {subject.Name}");

            for (int i = 0; i <  NumberOfQuestions; i++)
            {
                Console.WriteLine($"{i+1}- Header: {this.Questions[i].Header}");
                Console.WriteLine($"Body: {this.Questions[i].Body}");
                Console.WriteLine("CHoices:");
                for(int j = 0; j < this.Questions[i].Answers.Count; j++)
                {
                    Console.WriteLine($"{j+1} {this.Questions[i].Answers[j]}");
                }
                Console.WriteLine("=========================================");

            }
            solveExam();
            Console.WriteLine($"Practical Exam Solution for subject: {subject.Name}");
            ShowExamAnswer();

        }
    }
}
