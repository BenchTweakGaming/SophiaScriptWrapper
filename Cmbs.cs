using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

// UserFolders User Folders

namespace SophiaScriptWrapper
{
    public class Cmbs
    {
        public string CmbFunctionName { get; set; }
        public List<string> LstStrMainArg { get; set; }
        public int CountCmbInt { get; set; }
        public int WhichMainArgFirst { get; set; }
        public bool BoolTF { get; set; }
        public List<ComboBox> LstCmb1 { get; set; }
        public bool BoolWroteOppositeComment { get; set; }
        public Cmbs() // Constructor Blank
        {
            //
        }

        public Cmbs(string cmbFunctionName, List<string> lstStrMainArg, int countCmbInt, int whichMainArgFirst, bool boolTF, List<ComboBox> lstCmb1, bool boolWroteOppositeComment)
        {
            this.CmbFunctionName = cmbFunctionName;
            this.LstStrMainArg = lstStrMainArg;
            this.CountCmbInt = countCmbInt;
            this.WhichMainArgFirst = whichMainArgFirst;
            this.BoolTF = boolTF;
            this.LstCmb1 = lstCmb1;
            this.BoolWroteOppositeComment = boolWroteOppositeComment;           
        }
    }
}
