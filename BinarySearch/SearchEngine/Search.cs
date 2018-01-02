using BinarySearch.SearchEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.SearchEngine
{
    public static class Search
    {
        public static int SearchItem(int[] inArray, int value)
        {
            int result;

            // Checks
            if (inArray == null || inArray.Length == 0)
                result = -1;
            else
            {
                // Copy array to temp array for sorting
                int[] array = new int[inArray.Length];
                inArray.CopyTo(array, 0);
                Array.Sort(array);
                Interval interval = new Interval(array, 0, array.Length - 1);

                result = searchValue(interval, value, interval.FirstIndex, interval.LastIndex);

                // Search index in original array
                if (result != -1)
                    for (int i = 0; i < inArray.Length; i++)
                        if (inArray[i] == array[result])
                        {
                            result = i;
                            break;
                        }
            }

            return result;
        }

        private static int searchValue(Interval inInterval, int value, int firstIndex, int lastIndex)
        {
            int result;

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
