namespace Advanced01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /* if the array not sorted so there is at least one swap will happen in the second loop
            /* if not so the array is sorted and we dont need to continue
            */

            //int[] arr = { 7, 2, 6, 8, 1, 9, 22, 66, 25, 11, 34 };
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    bool swaped = false;
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            int tmp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = tmp;
            //            swaped = true;
            //        }
            //    }
            //    if (!swaped)
            //        break;

            //}

            //foreach (var item in arr)
            //    Console.WriteLine(item);
            #endregion

            #region Q2

            var r1 = new Range<int>(1,100);

            if(r1.IsInRange(50))
                Console.WriteLine("in range");
            else
                Console.WriteLine("out of range");

            Console.WriteLine(r1);
            Console.WriteLine($"Length of r1 is {r1.LengthOfRange()}");



            #endregion
        }

    }
}
