using System.Reflection;
using System.Xml.Linq;

namespace oopAss1
{
    internal class Program
    {
        enum WeekDays
        {
            saturday,
            monday,
            tuesday,
            wednesday,
            thursday,
            friday,
        }

        struct Person
        {
            public string name;
            public int age;

        }

        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }

        [Flags]
        enum Permissions
        {
            read = 1,
            write = 2,
            delete = 4,
            execute = 8
        }

        enum Colors
        {
            red,
            green,
            blue
        }

        struct Point
        {
            public double x;
            public double y;
        }
        static void Main(string[] args)
        {
            #region Q1

            // 1-	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum

            //foreach(WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}

            #endregion

            #region Q2

            // 2.	Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.

            //Person[] people = new Person[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"enter person {i+1} name");
            //    people[i].name = Console.ReadLine();
            //    Console.WriteLine($"enter person {i + 1} age");
            //    people[i].age = int.Parse(Console.ReadLine());

            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"person {i+1} name: {people[i].name}, person {i+1} age: {people[i].age}");
            //}


            #endregion

            #region Q3

            // 3.	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("enter season name");

            //Season s= (Season)Enum.Parse(typeof(Season),Console.ReadLine());

            //switch (s)
            //{
            //   case Season.Spring:
            //        Console.WriteLine("spring from march to may");
            //        break;

            //   case Season.Summer:
            //        Console.WriteLine("summer from june to agust");
            //        break;
            //   case Season.Autumn:
            //        Console.WriteLine("autumn from september to novmber");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("winter from december to february");
            //        break;
            //    default:
            //        Console.WriteLine("enter valid season");
            //        break;
            //}




            #endregion

            #region Q4

            // Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum

            //Permissions permission = Permissions.write;

            //foreach(Permissions p in Enum.GetValues(typeof(Permissions)))
            //{
            //    if ((permission & p) == p)
            //        Console.WriteLine($"user have {p} permission");
            //    else
            //        Console.WriteLine($"user don't have {p} permission");
            //}

            #endregion

            #region Q5

            // Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("enter color name");
            //string s = Console.ReadLine();

            //try
            //{
            //    Colors color = (Colors)Enum.Parse(typeof(Colors), s,true);

            //    Console.WriteLine($"{s} is a primary color");

            //}
            //catch
            //{

            //    Console.WriteLine($"{s} not a primary color");
            //}

            #endregion

            #region Q6

            // 6.	Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.

            //Console.WriteLine("enter point 1");
            //Point p1 = new Point();
            //p1.x = double.Parse(Console.ReadLine());
            //p1.y = double.Parse(Console.ReadLine());
            //Console.WriteLine("enter point2");
            //Point p2 = new Point();
            //p2.x = double.Parse(Console.ReadLine());
            //p2.y = double.Parse(Console.ReadLine());

            //double distance = Math.Sqrt((p2.x - p1.x) * (p2.x - p1.x) + (p2.y - p1.y) * (p2.y - p1.y));

            //Console.WriteLine($"destance between point 1 and point 2 is : {distance}");
            #endregion

            #region Q7

            // 7.	Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person


            //Person[] people = new Person[3];
            //int oldest = 0;
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"enter person {i + 1} name");
            //    people[i].name = Console.ReadLine();
            //    Console.WriteLine($"enter person {i + 1} age");
            //    people[i].age = int.Parse(Console.ReadLine());
            //    oldest = Math.Max(oldest, people[i].age);
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    if (people[i].age == oldest)
            //        Console.WriteLine($"name: {people[i].name} , age: {people[i].age}");
            //}
            #endregion


            #region part02

            Employee[] employee = new Employee[3];

            employee[0] = new Employee(
                _id: 1,
                _name: "seif",
                _securityLevel: SecurityLevel.DBA,
                _salary: 15000,
                _hireDate: new HireDate(1, 7, 2025),
                _gender: Gender.M
            );

            employee[1] = new Employee(
                _id: 2,
                _name: "amr",
                _securityLevel: SecurityLevel.Guest,
                _salary: 15000,
                _hireDate: new HireDate(2, 7, 2025),
                _gender: Gender.M
            );

            employee[2] = new Employee(
                _id: 3,
                _name: "ali",
                _securityLevel: SecurityLevel.Developer | SecurityLevel.Secretary | SecurityLevel.DBA | SecurityLevel.Guest,
                _salary: 15000,
                _hireDate: new HireDate(3, 7, 2025),
                _gender: Gender.M
            );

            foreach( Employee emp in employee )
            {
                Console.WriteLine(emp.ToString());
            }

            #endregion
        }
    }
}
