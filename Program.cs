using System;
using System.Collections;
namespace Ass02
{
    internal class Program
    {
        public static void reverse<T>(ref T[] arr)
        {
            if (arr is not null)
            {
                int l = 0, r = arr.Length - 1;
                while (l < r)
                {
                    T? tmp = arr[l];
                    arr[l] = arr[r];
                    arr[r] = tmp;

                    l++;
                    r--;
                }
            }
        }

        public static List<int> EvenOnly(List<int> list)
        {
            List<int> result = new List<int>();
            foreach (var item in list)
            {
                if(item%2==0)
                    result.Add(item);
            }
            return result;
        }

        public static bool IsPalindrom(int[] arr)
        {
            int l = 0, r = arr.Length-1;
            while (l < r)
            {
                if (arr[l] != arr[r])
                    return false;

                l++;
                r--;
            }
            return true;
        }

        public static T[] RemoveDuplicate<T>(T[] arr)
        {
            int cnt = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                if (arr[i].Equals(arr[i-1]))
                    cnt++;
            }
            T[] ans = new T[arr.Length-cnt];
            ans[0] = arr[0];
            for (int i = 1,j=1; i < arr.Length; i++)
            {
                if (!arr[i].Equals(arr[i - 1]))
                {
                    ans[j] = arr[i];
                    j++;
                }
            }
            return ans;
        }

        public static void RemoveOdd(ArrayList list)
        {
            for(int i =  list.Count-1; i >= 0; i--)
            {
                int tmp = (int)list[i];
                if (tmp%2==1)
                    list.RemoveAt(i);

            }
        }
        static void Main(string[] args)
        {
            #region Q1

            //int[] arr01 = { 1, 2, 3, 4, 5, 6, 7 };
            //string[] arr02 = { "seif", "ali", "amr", "ammar" };
            //double[] arr03 = { 1.1, 1.2, 1.3, 1.4 };
            //reverse<int>(ref arr01);
            //reverse<string>(ref arr02);
            //reverse<double>(ref arr03);

            //foreach (var item in arr01)
            //    Console.Write($"{item} ");
            //Console.WriteLine();
            //foreach (var item in arr02)
            //    Console.Write($"{item} ");
            //Console.WriteLine();
            //foreach (var item in arr03)
            //    Console.Write($"{item} ");
            #endregion

            #region Q2

            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10};
            //List<int> newList = EvenOnly(list);
            //foreach (var item in newList)
            //    Console.WriteLine(item);

            #endregion

            #region Q3

            //FixedSizeList<int> fixedList = new FixedSizeList<int>(3);
            ////Console.WriteLine(fixedList.GetValue(1));   // exception
            //fixedList.Add(1);
            //fixedList.Add(2);
            //fixedList.Add(3);
            //Console.WriteLine(fixedList.GetValue(1));
            ////fixedList.Add(4);   // exception




            #endregion

            #region Q4

            //int size, q;
            //size = int.Parse(Console.ReadLine());
            //q = int.Parse(Console.ReadLine());


            //int[] arr = new int[size];
            //for(int i = 0; i < size;i++)
            //    arr[i] = int.Parse(Console.ReadLine());

            //Array.Sort(arr);
            //while (q-- > 0)
            //{
            //    int value = int.Parse(Console.ReadLine());
            //    int ans = Array.BinarySearch(arr, value);
            //    if (ans < 0)
            //        ans = ans * (-1) - 1;
            //    Console.WriteLine($"ans = {size-ans}");

            //}




            #endregion

            #region Q5

            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];

            //for(int i = 0; i < size; i++)
            //    arr[i] = int.Parse(Console.ReadLine());
            //Console.WriteLine(IsPalindrom(arr));


            #endregion

            #region Q6

            //int[] arr = { 1, 1, 2, 2, 3, 3, 4, 5, 6 };
            //Array.Sort(arr);
            //arr = RemoveDuplicate<int>(arr);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q7

            //ArrayList list = new ArrayList(5)
            //{
            //    1,2, 3, 4, 5, 6, 7, 8, 9, 10
            //};

            //RemoveOdd(list);
            //foreach(var item in list)
            //    Console.WriteLine(item);

            #endregion
        }
    }
}
