using BinarySearch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.SearchTO
{
    class Factory
    {
        public ISearchTO GetSearchTO(Search model)
        {
            // For now only XML
            return new XMLImpl(model);
        }
    }
}
