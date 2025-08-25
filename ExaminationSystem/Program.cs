namespace ExaminationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject SW = new Subject(101,"Software");
            Subject os = new Subject(102, "operating System");
            FinalExam exam01 = new FinalExam(TimeSpan.FromMinutes(60), 2, SW);
            PracticalExam exam02 = new PracticalExam(TimeSpan.FromMinutes(60), 1, os);

            MCQQuestion q1 = new MCQQuestion(
               id: 1,
               header: "OOP concept",
               body: "which can Which concept allows creating objects from existing classes?",
               mark: 3,
               answers: new List<Answer> {
                    new Answer(10, "Encapsulation"),
                    new Answer(11, "Inheritance"),
                    new Answer(12, "Polymorphism"),
                    new Answer(13, "Abstraction")
               },
               rightAnswerId: 11
            );
            MCQQuestion q2 = new MCQQuestion(
               id: 2,
               header: "Data Structure",
               body: "which one is faster in get search",
               mark: 3,
               answers: new List<Answer> {
                    new Answer(20, "linkedList"),
                    new Answer(21, "array"),
                    new Answer(22, "node"),
                    new Answer(23, "none")
               },
               rightAnswerId: 21
            );

            TrueFalseQuestion q3 = new TrueFalseQuestion(
               id: 2,
               header: "Algorithms",
               body: "Binary search faster than linear search",
               mark: 3,
               rightAnswer: true
            );
            exam01.AddQuestion(q1);
            exam02.AddQuestion(q2);
            exam01.AddQuestion(q3);
            SW.CreateExam(exam01);
            os.CreateExam(exam02);
            os.exam.StartExam();


            Console.WriteLine("==============================");
            Console.WriteLine("Starting another exam");
            Console.WriteLine("==============================");
            SW.exam.StartExam();


        }
    }
}
