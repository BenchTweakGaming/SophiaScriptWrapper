using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

// InitialActions

namespace SophiaScriptWrapper
{
    public class CmbRequired
    {
        public string CmbFunctionName { get; set; }

        public List<string> LstStrMainArg { get; set; }
        public string RequiredIndex { get; set; }
        public ComboBox Cmb1 { get; set; }
        
        public List<bool> LstBoolCmb1 { get; set; }

        public CmbRequired() // Constructor Blank
        {
            //
        }

        public CmbRequired(string cmbFunctionName, List<string> lstStrMainArg, string requiredIndex, ComboBox cmb1, List<bool> lstBoolCmb1 )
        {
            this.CmbFunctionName = cmbFunctionName;
            this.LstStrMainArg = lstStrMainArg;            
            this.RequiredIndex = requiredIndex;
            this.Cmb1 = cmb1;
            this.LstBoolCmb1 = lstBoolCmb1;
        }
    }
}
