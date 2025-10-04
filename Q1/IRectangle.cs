using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAss03.Q1
{
    internal interface IRectangle : IShape
    {
        public double Width { get; set; }
        public double Hight { get; set; }
    }
}
