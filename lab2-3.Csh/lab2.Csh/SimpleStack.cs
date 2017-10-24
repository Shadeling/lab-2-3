using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.Csh
{
    class SimpleStack<T> : SimpleList<T> where T : IComparable
    {

        public void push(T element)
        {
            Add(element);
        }
        public T pop()
        {
            T test=Get(Count-1);
            last = null;
            if (Count > 0) { Count--; }
            return test;
        }
    }
}
