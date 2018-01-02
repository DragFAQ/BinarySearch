using BinarySearch.Model;
using BinarySearch.SearchTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.Controller
{
    class SearchController
    {
        public ISearchTO searchIndexByValue(Search search)
        {
            search.Run();

            return (new Factory()).GetSearchTO(search);
        }
    }
}
