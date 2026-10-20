using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SophiaScriptWrapper
{
    public class MoreData
    {
        public string StringMD { get; set; }

        public string StringMD2 { get; set; }

        public object ObjectMD { get; set; }
        public object ObjectMD2 { get; set; }

        public MoreData() // Constructor Blank
        {
            //
        }
        public MoreData(string stringMD, string stringMD2, object objectMD, object objectMD2)
        {
            this.StringMD = stringMD;
            this.StringMD2 = stringMD2;
            this.ObjectMD = objectMD;
            this.ObjectMD2 = objectMD2;
        }
    }
}
