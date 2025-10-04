using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAss03.Q1
{
    internal class Rectangle : IRectangle
    {

        public double Width { get ; set; }
        public double Hight { get ; set; }
        public double Area { get; set; }


        public Rectangle(double width, double hight)
        {
            Width = width;
            Hight = hight;
            Area = width * hight;
        }
        
        public void DisplayShapeInfo()
        {
            Console.WriteLine("This is rectangle");
            Console.WriteLine($"width: {Width}, hight: {Hight}, Area:{Area}");
        }
    }
}
