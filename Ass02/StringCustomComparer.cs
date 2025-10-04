using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass02
{
    internal class StringCustomComparer : IEqualityComparer<String>
    {
        public bool Equals(string? x, string? y)
        {
            if(ReferenceEquals(x, y)) return true;
            if(x == null || y == null || x.Length != y.Length) return false;
            
            var arr01 = new string(x.OrderBy(C => C).ToArray());
            var arr02 = new string(y.OrderBy(C => C).ToArray());

            return arr01.Equals(arr02);
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return new string(obj.OrderBy(C => C).ToArray()).GetHashCode();
        }
    }
}
