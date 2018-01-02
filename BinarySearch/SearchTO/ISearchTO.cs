using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.SearchTO
{
    interface ISearchTO
    {
        int[] Array { get; set; }
        int SearchValue { get; set; }
        int FoundIndex { get; set; }

        string GetAsString();
    }
}
