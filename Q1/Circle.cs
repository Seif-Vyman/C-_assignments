using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAss03.Q1
{
    internal class Circle : ICircle
    {
        public double Radius { get ; set; }
        public double Area { get ; set ; }

        public Circle(double radius)
        {
            Radius = radius;
            Area = radius * radius * Math.PI;
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine("This is circle");
            Console.WriteLine($"radius: {Radius}, area: {Area}");
        }
    }
}
