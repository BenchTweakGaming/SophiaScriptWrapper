using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

// Onedrive 

namespace SophiaScriptWrapper
{
    public class Cmbchkalter
    {
        public string CmbFunctionName { get; set; }
        public List<string> LstStrMainArg { get; set; }
        public int IndexOfInstall { get; set; }
        public string ChkFunctionName { get; set; }
        public string Function2Selects { get; set; }
        public ComboBox Cmb1 { get; set; }      
        public List<bool> LstBoolCmb1 { get; set; }
        public CheckBox Chk1 { get; set; }
        public bool BoolChk1 { get; set; }

        public Cmbchkalter() // Constructor Blank
        {
            //
        }

        public Cmbchkalter(string cmbFunctionName, List<string> lstStrMainArg, int indexOfInstall, string chkFunctionName, string function2Selects, ComboBox cmb1, List<bool> lstBoolCmb1, CheckBox chk1, bool boolChk1)
        {
            this.CmbFunctionName = cmbFunctionName;
            this.LstStrMainArg = lstStrMainArg;
            this.IndexOfInstall = indexOfInstall;
            this.ChkFunctionName = chkFunctionName;
            this.Function2Selects = function2Selects;
            this.Cmb1 = cmb1;
            this.LstBoolCmb1 = lstBoolCmb1;
            this.Chk1 = chk1;
            this.BoolChk1 = boolChk1;
        }
    }
}
