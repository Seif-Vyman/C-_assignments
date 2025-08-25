using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaminationSystem
{
    internal abstract class Exam
    {
        public TimeSpan Duration { get; set; }
        public int NumberOfQuestions { get; set; }
        public Subject subject { get; set; }
        protected List<Question> Questions;


        public Exam(TimeSpan duration, int numberofQuestions, Subject _subject) {
            Questions = new List<Question>();
            subject = _subject;
            Duration = duration;
            NumberOfQuestions = numberofQuestions;
        }
        public void AddQuestion(Question question)
        {
            if(this.NumberOfQuestions > Questions.Count)
            {
                Questions.Add(question);
            }
            else
                Console.WriteLine("Can't add more questions the exam full of questions");
        }
        public abstract void StartExam();
           

        public List<int> solveExam()
        {
            List<int>studentAnswers = new List<int>();
            Console.WriteLine("chose Answers by answer Id");
            for (int i = 0; i < Questions.Count; i++)
            {
                Console.WriteLine($"Enter answerId for question number {i + 1}");
                bool studentAnswerCheck = true;
                int studentAnswer;
                do
                {
                    if (!studentAnswerCheck)
                        Console.WriteLine("Enter valid input");
                    studentAnswerCheck = int.TryParse(Console.ReadLine(), out studentAnswer);
                } while (!studentAnswerCheck);

                studentAnswers.Add(studentAnswer);

            }
            return studentAnswers;

        }
        public void ShowExamAnswer()
        {

            for (int i = 0; i < NumberOfQuestions; i++)
            {
                int correctAnswerId = this.Questions[i].RightAnswerId;
                for(int j =0; j< this.Questions[i].Answers.Count;j++)
                    if (this.Questions[i].Answers[j].AnswerId == correctAnswerId)
                        Console.WriteLine($"{i + 1}) {this.Questions[i].Answers[j]}");
            }
        }
        


    }
}
