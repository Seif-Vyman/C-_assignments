using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Advanced01
{
    internal class Range<T> where T : IComparable<T> , INumber<T>
    {

        public T Minimum { get; set; }
        public T Maximum { get; set; }
        public Range(T minimum, T maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        public bool IsInRange(T? value)
        {
            if(value == null) return false;

            return value?.CompareTo(Minimum) >= 0 && value?.CompareTo(Maximum) <= 0? true : false; 
        }

        public T LengthOfRange()
        {
            return Maximum - Minimum;
        }

        public override string ToString()
        {
            return $"Range from {Minimum} to {Maximum}";
        }


    }
}
