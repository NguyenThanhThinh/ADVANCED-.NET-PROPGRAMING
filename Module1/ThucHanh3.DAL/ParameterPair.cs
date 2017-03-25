using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThucHanh3.DAL
{
    public class ParameterPair
    {
        public string ParameterName { set; get; }
        public string Value { set; get; }

        public ParameterPair(string name, string value)
        {
            ParameterName = name;
            Value = value;
        }
    }
}
