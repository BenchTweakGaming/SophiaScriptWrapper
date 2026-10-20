using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

// UWP -ForAllUSers

namespace SophiaScriptWrapper
{
    public class Chkchkalter
    {
        public string Chk1FunctionName { get; set; }
       
        public string Chk2FunctionName { get; set; }
        public CheckBox Chk1 { get; set; }

        public bool BoolChk1 { get; set; }

        public CheckBox Chk2 { get; set; }

        public bool BoolChk2 { get; set; }

        public Chkchkalter() // Constructor Blank
        {
            //
        }

        public Chkchkalter(string chk1FunctionName, string chk2FunctionName, CheckBox chk1, bool boolChk1, CheckBox chk2, bool boolChk2)
        {
            this.Chk1FunctionName = chk1FunctionName;           
            this.Chk2FunctionName = chk2FunctionName;            
            this.Chk1 = chk1;
            this.BoolChk1 = boolChk1;
            this.Chk2 = chk1;
            this.BoolChk2 = boolChk1;
        }
    }
}
