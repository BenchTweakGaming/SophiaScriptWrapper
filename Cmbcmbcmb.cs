using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

// DNSoverHTTPS

namespace SophiaScriptWrapper
{
    public class Cmbcmbcmb
    {
        public string CmbFunctionName { get; set; }
        public List<string> LstStrMainArg { get; set; }
        public int CountCmbInt { get; set; }
        public List<string> LstStrPrefixes { get; set; }        
        public bool BoolTF { get; set; }
        public List<ComboBox> LstCmb1 { get; set; }      

        public Cmbcmbcmb() // Constructor Blank
        {
            //
        }

        public Cmbcmbcmb(string cmbFunctionName, List<string> lstStrMainArg, int countCmbInt, List<string> lstStrPrefixes, bool boolTF, List<ComboBox> lstCmb1)
        {
            this.CmbFunctionName = cmbFunctionName;
            this.LstStrMainArg = lstStrMainArg;
            this.CountCmbInt = countCmbInt;
            this.LstStrPrefixes = lstStrPrefixes;
            this.BoolTF = boolTF;
            this.LstCmb1 = lstCmb1;            
        }
    }
}
