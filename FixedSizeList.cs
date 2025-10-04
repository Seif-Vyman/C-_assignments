using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass02
{
    internal class FixedSizeList<T>
    {
        int Capacity;
        int Index = -1;
        T[] _list;

        public FixedSizeList(int capacity)
        {
            Capacity = capacity;
            _list = new T[capacity];
        }

        public void Add(T item)
        {
            if (Index < Capacity - 1)
                _list[++Index] = item;
            else
                throw new IndexOutOfRangeException();
        }
        public T GetValue(int index) {
            if(index>=0 && index <= Index)
                return _list[index];
            throw new IndexOutOfRangeException();
        }
    }
}
