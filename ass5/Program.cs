namespace ass5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q19

            // Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //Console.WriteLine("enter size of matrix");
            //int n = int.Parse(Console.ReadLine());
            //int id = 1;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        Console.Write($"{id} ");
            //        id++;
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Q20

            // Write a program in C# Sharp to find the sum of all elements of the array.

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //    sum += arr[i];
            //Console.WriteLine(sum);


            #endregion

            #region Q21

            // Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order

            //int[] arr1 = { 1, 3, 5, 7, 9 };
            //int[] arr2 = {2,4,6,8,10 };

            //int[] merg = new int[arr1.Length+arr2.Length];

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    merg[i] = arr1[i];
            //    merg[i+arr2.Length] = arr2[i];
            //}
            //Array.Sort(merg);
            //for(int i = 0; i < merg.Length; i++)
            //    Console.Write($"{merg[i]} ");

            #endregion

            #region Q22

            // Write a program in C# Sharp to count the frequency of each element of an array.

            //int[] arr = { 1, 1, 1, 4, 6, 13, 22, 54, 4, 6, 6, 13, 5, 5, 5, 2, 254, 54, 7, 7, 77 };
            //int[] freq = new int[2_000_000_000];

            //for (int i = 0; i < arr.Length; i++)
            //    freq[arr[i]]++;

            //for(int i=0; i< arr.Length; i++)
            //{
            //    if (freq[arr[i]] > 0)
            //    {
            //        Console.WriteLine($"frequency of {arr[i]} is {freq[arr[i]]}");
            //        freq[arr[i]] = -1;
            //    }
            //}

            #endregion

            #region Q23

            //int[] arr = { 1, 1, 1, 4, 6, 13, 22, 54, 4, 6, 6, 13, 5, 5, 5, 2, 254, 54, 7, 7, 77 };

            //int maxValue = int.MinValue, minValue = int.MaxValue;
            //for(int i = 0; i< arr.Length; i++)
            //{
            //    maxValue = int.Max(maxValue, arr[i]);
            //    minValue = int.Min(minValue, arr[i]);
            //}
            //Console.WriteLine($"max value is {maxValue}, the min value {minValue}");

            #endregion

            #region Q24

            // Write a program in C# Sharp to find the second largest element in an array.

            //int[] arr = { 1, 1, 1, 4, 6, 13, 22, 54, 4, 6, 6, 13, 5, 5, 5, 2, 254, 54, 7, 7, 77 };

            //Array.Sort(arr);
            //if (arr.Length >= 2)
            //    Console.WriteLine($"the second maxmum value is {arr[arr.Length - 2]}");

            //else
            //    Console.WriteLine("the array has only one value");

            #endregion

            #region Q25

            //Console.WriteLine("enter the size of array");
            //int size = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter array elements");
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //    arr[i] = int.Parse(Console.ReadLine());

            //int distance = -1,f = -1, sec = -1;

            //for (int i = 0;i < size; i++)
            //{
            //    int l = i, r = size - 1;
            //    while(l< r)
            //    {
            //        if (arr[l] == arr[r])
            //        {
            //            if(distance< r - l - 1)
            //            {
            //                distance = r - l - 1;
            //                f = l;
            //                sec = r;
            //            }
            //            break;
            //        }
            //        r--;
            //    }
            //}
            //if(distance == -1)
            //    Console.WriteLine("there is no two equal elements");
            //else
            //    Console.WriteLine($" the longest distance is between element {f+1} and element {sec+1} with distance of {distance} cells");
            #endregion

            #region Q26

            //Console.WriteLine("enter statmenet with space separted words");

            //string s;
            //s = Console.ReadLine();

            //s = string.Join(" ", s.Split(' ').Reverse());
            //Console.WriteLine(s);

            #endregion

            #region Q27

            //Console.WriteLine("enter size of multidimensional array");
            //int row = int.Parse(Console.ReadLine());
            //int column = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter 2d array values");

            //int[,] arr1 = new int[row,column];
            //int[,] arr2 = new int[row,column];

            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //}

            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //        arr2[i, j] = arr1[i,j];
            //}

            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //        Console.Write($"{arr2[i,j]} ");
            //    Console.WriteLine();
            //}
            #endregion

            #region Q28

            // Write a Program to Print One Dimensional Array in Reverse Order

            //Console.WriteLine("enter array size");
            //int size = int.Parse(Console.ReadLine());

            //Console.WriteLine("enter array elements");
            //int[] arr = new int[size];

            //for (int i = 0; i < size; i++)
            //    arr[i] = int.Parse(Console.ReadLine());

            //for (int i = size - 1;i >= 0; i--)
            //    Console.Write($"{arr[i]} ");

            #endregion
        }
    }
}
