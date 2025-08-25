using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal class FinalExam : Exam
    {

        public FinalExam(TimeSpan duration, int numberofQuestions, Subject _subject) : base(duration, numberofQuestions, _subject)
        {
         
        }

        public override void StartExam()
        {
            if (NumberOfQuestions > 0 && this.Questions is not null)
            {
                Console.WriteLine($"Final Exam for subject: {subject.Name}");

                for (int i = 0; i < NumberOfQuestions; i++)
                {
                    Console.WriteLine($"{i + 1}- Header: {this.Questions[i].Header}");
                    Console.WriteLine($"Body: {this.Questions[i].Body}");
                    Console.WriteLine("CHoices:");
                    for (int j = 0; j < this.Questions[i].Answers.Count; j++)
                    {
                        Console.WriteLine($"{j + 1} {this.Questions[i].Answers[j]}\t");
                    }
                    Console.WriteLine("=========================================");
                }

                List<int>studentAsnwers = solveExam();
                int totalMarks = 0,studentMarks=0;
                for(int i = 0; i < studentAsnwers.Count; i++)
                {
                    totalMarks += this.Questions[i].Mark;
                    studentMarks += this.Questions[i].IsCorrect(studentAsnwers[i]);
                }

                Console.WriteLine($"Final Exam Solution for subject: {subject.Name}");
                ShowExamAnswer();
                Console.WriteLine($"Student Marks = {studentMarks}/{totalMarks}");


            }
            else { Console.WriteLine("There is no questions in exam"); }
            

        }
    }
}
