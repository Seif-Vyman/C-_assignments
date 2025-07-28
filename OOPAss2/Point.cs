using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAss2
{
    internal class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point():this(0,0,0)
        {
        }
        public Point(double x):this(x,0,0)
        {
        }
        public Point(double x, double y):this(x,y,0)
        {
            
        }
        public Point(double x, double y, double z)
        {
            X = x;
            Y = y; 
            Z = z;
        }


        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
    }
}
