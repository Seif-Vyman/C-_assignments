namespace ass2
{
    internal class Program
    {
        class refrenceType
        {
            public int num;
        }
        static void Main(string[] args)
        {
            #region Q1

            // 1-	Write a program that allows the user to enter a number then print it
            /*
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num);
            */
            #endregion

            #region Q2
            // 2-	Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            /*
            Console.WriteLine("enter string to convert to int");
            int num = int.Parse(Console.ReadLine());

            // it will through exception because the string cannot be converted if it is non-numeric
            */
            #endregion

            #region Q3
            // 3-	Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            /*
            Console.WriteLine("enter two floating point numbers");
            float num1 = float.Parse(Console.ReadLine());
            float num2 = float.Parse(Console.ReadLine());

            float summation= num1 + num2;
            Console.WriteLine(summation);

            // the operation will happend successfully by summing the floating numbers

            */
            #endregion

            #region Q4
            // 4-	Write C# program that Extract a substring from a given string.
            /*
            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            Console.WriteLine("chosse start and end index of substring");
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine($"substring is {s.Substring(start-1,end)}");
            */
            #endregion


            #region Q5
            // 5-	Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            /*
            int num1 = 7;
            int num2 = num1;

            num2--;

            Console.WriteLine(num2);
            // num2 modified but num1 still with the same value
            */
            #endregion

            #region Q6
            // 6-	Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            /*
            refrenceType r1 = new refrenceType();
            refrenceType r2 = new refrenceType();
            
            r1.num = 5;
            r2 = r1;
            Console.WriteLine($"before modify: r1 = {r1.num}, r2 = {r2.num}");
            r2.num = 7;
            Console.WriteLine($"after modify: r1 = {r1.num}, r2 = {r2.num}");

            // r1 modified with the modification of r2 because r2 reference to r1
            */

            #endregion

            #region Q7
            // 7-	Write C# program that take two string variables and print them as one variable
            /*
            Console.WriteLine("enter two strings");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            Console.WriteLine(string.Concat(s1,' ',s2));

            */
            #endregion

            #region Q8
            // 8-	Which of the following statements is correct about the C#.NET code snippet given below?

            // b)	A value 1 will be assigned to d.

            #endregion

            #region Q9
            // 9-	Which of the following is the correct output for the C# code given below?

            // d)	6 1
            #endregion

            #region Q10
            // What will be the output of the C# code given below?

            // d)	7 7

            #endregion


        }
    }
}
