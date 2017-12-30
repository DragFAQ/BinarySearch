using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.SearchEngine
{
    class Interval
    {
        private int[] values;
        private int firstIndex;
        private int lastIndex;

        public Interval(int[] array, int firstIndex, int lastIndex)
        {
            values = array;
            this.firstIndex = firstIndex;
            this.lastIndex = lastIndex;
        }

        public int getHalfIndex()
        {
            return (lastIndex - firstIndex) / 2 + firstIndex;
        }
    }
}
