using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

// Prevent Edge Shortcut Creation

namespace SophiaScriptWrapper
{
    public class Cmbchk
    {
        public string CmbFunctionName { get; set; }
        public List<string> LstStrMainArg { get; set; }
        public List<string> LstStrChkArg { get; set; }        
        public ComboBox MainCmb { get; set; }
        public List<bool> LstBoolMainCmb { get; set; }
        public List<CheckBox> LstChk { get; set; }   
        public int IndexOfMainArg { get; set; }
        
        public Cmbchk() // Constructor Blank
        {
            //
        }
        
        public Cmbchk(string cmbFunctionName, List<string> lstStrMainArg, List<string> lstStrChkArg, ComboBox mainCmb, List<bool> lstBoolMainCmb, List<CheckBox> lstChk, bool boolTF , int indexOfMainArg)
        {
            this.CmbFunctionName = cmbFunctionName;
            this.LstStrMainArg = lstStrMainArg;
            this.LstStrChkArg = lstStrChkArg;
            this.MainCmb = mainCmb;
            this.LstBoolMainCmb = lstBoolMainCmb;
            this.LstChk = lstChk;            
            this.IndexOfMainArg = indexOfMainArg;           
        }
    }
}
