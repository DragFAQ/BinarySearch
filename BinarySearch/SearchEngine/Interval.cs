using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.SearchEngine
{
    class Interval
    {
        public int[] Values { get; }
        public int FirstIndex { get; }
        public int LastIndex { get; }

        public Interval(int[] array, int firstIndex, int lastIndex)
        {
            Values = array;
            FirstIndex = firstIndex;
            LastIndex = lastIndex;
        }

        public int getHalfIndex()
        {
            return (LastIndex - FirstIndex) / 2 + FirstIndex;
        }

        public int getSize()
        {
            return LastIndex - FirstIndex + 1;
        }

        internal int getItem(int index)
        {
            // TODO: Check for interval contains "index" if (index >= FirstIndex && index <= LastIndex)
            return Values[index];
        }
    }
}
