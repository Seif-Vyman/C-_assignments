using System.Buffers.Text;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ass6
{
    internal class Program
    {
        static void swapByValue(int a, int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        static void swapByReference(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }

        static void multipl2ByValue(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] *= 2;
        }

        static void multipl2ByReference(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                arr[i] *= 2;
        }

        static void sumAndSubtract(int a, int b, out int sum, out int sub)
        {
            sum = a + b;
            sub = a - b;
        }

        static int sumOfDigit(int num)
        {
            int res = 0;
            while(num > 0)
            {
                res += num % 10;
                num /= 10;
            }
            return res;
        }

        static bool isPrime(int num)
        {
            if(num<2)
                return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }

            return true;
        } 

        static void minMaxArray(ref int[] arr, ref int min, ref int max)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                min = int.Min(min, arr[i]);
                max = int.Max(max, arr[i]);
            }
        }

        static long fac(int num)
        {
            long res = 1;
            for (int i = 2; i <= num; i++)
            {
                res *= i;
            }
            return res;

        }

        static string changeChar(string s, int pos, char c)
        {
            return s.Substring(0, pos) + c + s.Substring(pos + 1);

        }
        static void Main(string[] args)
        {
            #region Q1

            // 1- Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c#example.

            /*
             * in value type when we pass value by value i just sent the value of the agument i sent so any change does in the reciceved variables in the function doesn't affect on the main argument
             * 
             * in passing by reference i sent the address of the argument not the value so any change does affect on the main argument i sent 
             */

            // EX:
            //int x = 5, y = 6;
            //Console.WriteLine("-----before passing by value-------");
            //Console.WriteLine($"x = {x}, y = {y}");
            //swapByValue(x, y);
            //Console.WriteLine("------- after passing by value");
            //Console.WriteLine($"x = {x}, y = {y}");


            //Console.WriteLine("-----before passing by reference-------");
            //Console.WriteLine($"x = {x}, y = {y}");
            //swapByReference(ref x, ref y);
            //Console.WriteLine("------- after passing by reference");
            //Console.WriteLine($"x = {x}, y = {y}");




            #endregion

            #region Q2

            // Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            /*
             * in reference type when passing by value and change the value that passed the main argument value chnages too and in passing by reference the same too 
             * 
             * the diff is in passing by value new variables created in the stack hold the address of the argument since in passing by reference no variables created but the main argument be labled by the name of the paramteres
             */

            // EX:

            //int[] arr = { 1, 2, 3};

            //Console.WriteLine("-----before passing by value-------");
            //for(int i = 0; i < arr.Length;i++)
            //    Console.Write($"{arr[i]} ");
            //multipl2ByValue(arr);
            //Console.WriteLine("\n------- after passing by value");
            //for (int i = 0; i < arr.Length; i++)
            //    Console.Write($"{arr[i]} ");


            //Console.WriteLine("\n-----before passing by value-------");
            //for (int i = 0; i < arr.Length; i++)
            //    Console.Write($"{arr[i]} ");
            //multipl2ByReference(ref arr);
            //Console.WriteLine("\n------- after passing by value");
            //for (int i = 0; i < arr.Length; i++)
            //    Console.Write($"{arr[i]} ");


            #endregion

            #region Q3

            //  Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //int num1 = 10, num2 = 5, sum, sub;

            //sumAndSubtract(num1, num2, out sum, out sub);
            //Console.WriteLine($"sum = {sum}, subtract = {sub}");


            #endregion

            #region Q4

            //  Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            //int num;
            //Console.WriteLine("enter number");
            //num = int.Parse(Console.ReadLine());

            //int res = sumOfDigit(num);

            //Console.WriteLine($"sum of digit = {res}");

            #endregion

            #region Q5

            // Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:

            //Console.WriteLine("enter number");
            //int num = int.Parse(Console.ReadLine());

            //if(isPrime(num))
            //    Console.WriteLine("the number is prime");
            //else
            //    Console.WriteLine("the numbe is not prime");

            #endregion

            #region Q6

            // Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //Console.WriteLine("enter size of array");
            //int size = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter elements");
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //    arr[i] = int.Parse(Console.ReadLine());

            //int max = int.MinValue, min = int.MaxValue;

            //minMaxArray(ref arr, ref min, ref max);
            //Console.WriteLine($"minimum value = {min}, maximum value = {max}");


            #endregion

            #region Q7

            // Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //Console.WriteLine("enter num");
            //int num = int.Parse(Console.ReadLine());

            //long res = fac(num);

            //Console.WriteLine($"factorial of {num} is {res}");



            #endregion

            #region Q8

            // Create a function named "ChangeChar" to modify a letter in a certain position(0 based) of a string, replacing it with a different letter

            //Console.WriteLine("enter string");
            //string s = Console.ReadLine();

            //Console.WriteLine("enter position want to change");
            //int pos = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter char want to change to");
            //char c = char.Parse(Console.ReadLine());

            //s = changeChar(s, pos, c);

            //Console.WriteLine($"new string is {s}");

            #endregion
        }
    }
}
