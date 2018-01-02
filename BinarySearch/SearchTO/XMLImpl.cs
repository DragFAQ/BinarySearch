using BinarySearch.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch.SearchTO
{
    public class XMLImpl : ISearchTO
    {
        public int[] Array { get; set; }
        public int SearchValue { get; set; }
        public int FoundIndex { get; set; }

        public XMLImpl()
        {
        }

        public XMLImpl(Search model)
        {
            Array = model.Array;
            SearchValue = model.SearchValue;
            FoundIndex = model.FoundIndex;
        }

        public string GetAsString()
        {
            string result = "";

            System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this.GetType());
            using (var sww = new StringWriter())
            {
                x.Serialize(sww, this);
                result = sww.ToString();
            }

            return result;
        }
    }
}
