using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Experimental
// new type of string for wrapperconfig and looping for better efficiency

namespace SophiaScriptWrapper
{
    internal class wstring
    {
        public string NameOfVariable { get; set; }

        public string Value { get; set; }
        public dynamic Data { get; set; }
        public wstring() { }

        public wstring(string nameofvariable, string value, dynamic data)
        {            
            this.NameOfVariable = nameofvariable;
            this.Value = value;
            this.Data = data;
        }
    }
}
