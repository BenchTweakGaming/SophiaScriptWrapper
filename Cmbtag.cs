using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Special Functions

namespace SophiaScriptWrapper
{
    public class Cmbtag
    {
        public string CmbFunctionName { get; set; }
        public bool BoolTF { get; set; }       

        public Cmbtag() // Constructor Blank
        {
            //
        }

        public Cmbtag(string cmbFunctionName, bool boolTF)
        {
            this.CmbFunctionName = cmbFunctionName;
            this.BoolTF = boolTF;
            
        }
    }
}
