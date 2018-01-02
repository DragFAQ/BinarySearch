using BinarySearch.SearchEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.Model
{
    public class Search
    {
        public int[] Array { get; set; }
        public int SearchValue { get; set; }
        public int FoundIndex { get; set; }

        public Search(int[] array, int searchValue)
        {
            Array = array;
            SearchValue = searchValue;
        }

        public void Run()
        {
            FoundIndex = SearchEngine.Search.SearchItem(Array, SearchValue);
        }
    }
}
