namespace ass3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // 1- Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            /*Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            if (num % 3 == 0 && num % 4 == 0)
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");*/
            #endregion

            #region Q2
            // Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            /*Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
                Console.WriteLine("negative");
            else
                Console.WriteLine("positive");*/

            #endregion

            #region Q3
            // Write a program that takes 3 integers from the user then prints the max element and the min element.
            /*
            Console.WriteLine("insert three numbers");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int maxNum = Math.Max(num1, num2);
            maxNum = Math.Max(maxNum, num3);
            int minNum = Math.Min(num1, num2);
            minNum = Math.Min(minNum, num3);

            Console.WriteLine($"the maximum number is {maxNum}, the minimum number is {minNum}");
            */
            #endregion

            #region Q4
            // Write a program that allows the user to insert an integer number then check If a number is even or odd.
            /*
            Console.WriteLine("enter number");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("even");
            else
                Console.WriteLine("odd");
            */
            #endregion

            #region Q5

            // Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            /*
            Console.WriteLine("enter character");
            char c = char.Parse(Console.ReadLine());
            if (char.ToLower(c) == 'a' || char.ToLower(c) == 'e' || char.ToLower(c) == 'i' || char.ToLower(c) == 'o' || char.ToLower(c) == 'u')
                Console.WriteLine("vowel");
            else
                Console.WriteLine("Consonant");
            */
            #endregion
        }
    }
}
