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

            searchValue(interval, value);

            return -1;
        }

        private static void searchValue(Interval interval, int value)
        {
            throw new NotImplementedException();
        }
    }
}
