using System.Text;

namespace test
{

    class order
    {
        public int id { get; set; }
        public OrderItem[] Items { get; set; }
    }

    class OrderItem
    {
        public int id { get; set; }
        public string name { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region boxing and unboxing


            //// boxing : casting from value type to reference type
            //// unboxing: castring from reference type to value type

            //object obj;
            //obj = new object();
            //obj = new string("seif");   // not boxing because object and string are reference type

            //obj = 5;         // boxing,    implicit casting
            //obj = "seif";   // boxing,     implicit casting

            //int num1 = (int)obj; // unboxing : unsafe casting
            //int num2 = obj.GetType() == typeof(int) ? (int)obj : 0; // unboxing : safe casting
            //int num3 = obj is int ? (int)obj : 0;   // unboxing : safe casting

            //// try to avoid boxing and unboxing
            #endregion

            #region nullable value

            permission p = new permission();
            p = permission.read;
            Console.WriteLine(p|=permission.write);




            #endregion

        }

        [Flags]
        public enum permission
        {
            read = 4,
            write = 2,
            delete = 1
   
        }
    }
}
