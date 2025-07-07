namespace ass4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q6

            // Write a program that allows the user to insert an integer then print all numbers between 1 to that number

            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= num; i++)
            //    Console.Write($"{i} ");
            #endregion

            #region Q7

            // Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //    Console.Write($"{i*num} ");

            #endregion

            #region Q8

            // Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());
            //for (int i = 2; i <= num; i+=2)
            //    Console.Write($"{i} ");


            #endregion

            #region Q9

            // Write a program that takes two integers then prints the power.

            //Console.WriteLine("enter base number and power number");
            //int b = int.Parse(Console.ReadLine());
            //int p = int.Parse(Console.ReadLine());
            //int result = 1;
            //for (int i = 0; i < p; i++)
            //    result *= b;
            //Console.WriteLine(result);


            #endregion

            #region Q10

            // Write a program to enter marks of five subjects and calculate total, average and percentage.

            //Console.WriteLine("enter marks of five subjects");
            //int total = 0;
            //for (int i = 0; i < 5; i++)
            //    total += int.Parse(Console.ReadLine());
            //Console.WriteLine($"total marks = {total}");
            //Console.WriteLine($"average marks = {total/5}");
            //Console.WriteLine($"percentage marks = {total/5}");


            #endregion

            #region Q11

            // Write a program to input the month number and print the number of days in that month.

            //int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            //Console.WriteLine("enter number of month");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(months[n - 1]);

            #endregion

            #region Q12

            // Write a program to create a Simple Calculator.

            //bool n1, o, n2;
            //int num1, num2;
            //char opreator;
            //do
            //{
            //    Console.WriteLine("enter two numbers and arthimetic opreator");

            //    n1 = int.TryParse(Console.ReadLine(), out num1);
            //    o = char.TryParse(Console.ReadLine(), out opreator);
            //    n2 = int.TryParse(Console.ReadLine(), out num2);
            //} while (!n1 || !o || !n2);
            //switch (opreator)
            //{
            //    case '+':
            //        Console.WriteLine($"{num1} {opreator} {num2} = {num1 + num2}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"{num1} {opreator} {num2} = {num1 - num2}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"{num1} {opreator} {num2} = {num1 * num2}");
            //        break;
            //    case '/':
            //        Console.WriteLine($"{num1} {opreator} {num2} = {num1 / num2}");
            //        break;

            //    default:
            //        Console.WriteLine("enter valid opreator");
            //        break;
            //}

            #endregion

            #region Q13

            // Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.WriteLine("enter string");
            //string s = Console.ReadLine();
            //for (int i = s.Length-1; i >=0 ; i--)
            //    Console.Write(s[i]);
            #endregion

            #region Q14

            // Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.WriteLine("enter integer");
            //int n = int.Parse(Console.ReadLine());
            //int reversed = 0;
            //while (n>0) {

            //    reversed = reversed * 10 + n % 10;
            //    n /= 10; 
            //}
            //Console.WriteLine(reversed);

            #endregion

            #region Q15

            // Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.WriteLine("enter starting and ending number for the range");
            //int start = int.Parse(Console.ReadLine());
            //int end = int.Parse(Console.ReadLine());

            //for(int i = start; i <= end; i++)
            //{
            //    bool check = true;
            //    for(int j = 2; j<= Math.Sqrt(i); j++)
            //    {
            //        if(j != i && i%j==0)
            //            check = false;
            //    }
            //    if(check && i != 1)
            //        Console.Write($"{i} ");

            //}

            #endregion

            #region Q17

            // Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.

            //Console.WriteLine("enter point 1");
            //int point1x = int.Parse(Console.ReadLine());
            //int point1y = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter point 2");
            //int point2x = int.Parse(Console.ReadLine());
            //int point2y = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter point 3");
            //int point3x = int.Parse(Console.ReadLine());
            //int point3y = int.Parse(Console.ReadLine());

            //int slop1 = (point2y - point1y) / (point2x - point1x);
            //int slop2 = (point3y - point1y) / ( point3x - point1x);

            //if (slop1 == slop2)
            //    Console.WriteLine("these points lie on a single straight line");
            //else
            //    Console.WriteLine("these points don't lie on a single straight line");

            #endregion

            #region Q18

            //Console.WriteLine("enter task time");
            //int time = int.Parse(Console.ReadLine());


            //string level = time switch
            //{
            //    >=2 and < 3 => "they are considered highly efficient.",
            //    >=3 and <4 => "they are instructed to increase their speed.",
            //    >=4 and <5 => "they are provided with training to enhance their speed.",
            //    >=5 => "they are required to leave the company.",
            //    _=> "The finished the work less than 2 hours they are professional" 
            //};
            //Console.WriteLine(level);

            #endregion
        }
    }
}
