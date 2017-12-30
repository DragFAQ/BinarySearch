using BinarySearch.SearchEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class Search
    {
        public static int SearchItem(int[] array, int value)
        {
            Interval interval = new Interval(array, 0, array.Length - 1);

            return searchValue(interval, value, interval.FirstIndex, interval.LastIndex);
        }

        private static int searchValue(Interval inInterval, int value, int firstIndex, int lastIndex)
        {
            int result = -1;

            Interval interval = new Interval(inInterval.Values, firstIndex, lastIndex);
            if (interval.getSize() < 3)
            {
                result = interval.getItem(interval.FirstIndex) == value ? interval.FirstIndex : -1;
                if (result == -1)
                    result = interval.getItem(interval.LastIndex) == value ? interval.LastIndex : -1;
            }
            else
            {
                int halfIndex = interval.getHalfIndex();

                if (interval.getItem(halfIndex) == value)
                    result = halfIndex;
                else if (interval.getItem(halfIndex) > value)
                    result = searchValue(interval, value, interval.FirstIndex, halfIndex - 1);
                else
                    result = searchValue(interval, value, halfIndex + 1, interval.LastIndex);
            }

            return result;
        }
    }
}
