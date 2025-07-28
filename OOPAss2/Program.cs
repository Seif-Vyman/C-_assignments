namespace OOPAss2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region project1

            //Point p1 = new Point();
            //Point p2 = new Point();

            //Console.WriteLine("enter 3d point Coordinates for point 1");
            //p1.X = double.Parse(Console.ReadLine());
            //p1.Y = double.Parse(Console.ReadLine());
            //p1.Z = double.Parse(Console.ReadLine());

            //Console.WriteLine("enter 3d point Coordinates for point 2");

            //p2.X = double.Parse(Console.ReadLine());
            //p2.Y = double.Parse(Console.ReadLine());
            //p2.Z = double.Parse(Console.ReadLine());

            // trying to use ==

            //if(p1 == p2)
            //    Console.WriteLine("equals");
            //else
            //    Console.WriteLine("not equals");
            // it compile but don't get correct comparison -- need for opereator overloading


            //Point[] points = new Point[]
            //{
            //    new Point(15,14,13),
            //    new Point(12,11,10),
            //    new Point(9,8,7),
            //    new Point(6,5,4),
            //    new Point(3,2,1),
            //};

            //Array.Sort(points, (a, b) => a.X.CompareTo(b.X));

            //foreach (var point in points)
            //{
            //    Console.WriteLine(point);
            //}
            #endregion

            #region project2

            //int x = 5, y = 6;
            //int sum = (int) Maths.Add(x, y);
            //Console.WriteLine(sum);
            #endregion

            #region project3

            Duration D1 = new Duration(1, 10, 15);
            D1.ToString();


            Duration D2 = new Duration(3600);
            D1.ToString();

            Duration D3 = D1 + D2;
            Console.WriteLine($"D3 = {D3}");
            Duration D4 = D1 - D2;
            Console.WriteLine($"D4 = {D4}");
            Duration D5 = D1 + 50;
            Console.WriteLine($"D5 = {D5}");
            D1++;
            D2--;
            Console.WriteLine($"D1: {D1}, D2: {D2}");
            
            if(D1>=D2)
            {
                Console.WriteLine("D1 greater than or equal D2");
            }
            else
                Console.WriteLine("D2 greater than D1");

            DateTime dt = (DateTime)D1;
            Console.WriteLine(dt);


            #endregion
        }
    }
}
