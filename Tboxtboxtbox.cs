using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

// Set-Association

namespace SophiaScriptWrapper
{
    public class Tboxtboxtbox
    {
        public string TboxFunctionName { get; set; }
        public int CountTboxInt { get; set; }
        public bool BoolTF { get; set; }
        public ComboBox CmbTboxTboxTbox1 { get; set; }
        public TextBox Tbox1 { get; set; }
        public TextBox Tbox2 { get; set; }
        public TextBox Tbox3 { get; set; }
        public ComboBox Cmb2 { get; set; }
        public List<Button> ListBtns { get; set; }
        public Tboxtboxtbox() // Constructor Blank
        {
            //
        }
        public Tboxtboxtbox(string tboxFunctionName, int countTboxInt, bool boolTF, ComboBox cmbTboxTboxTbox1, TextBox tbox1, TextBox tbox2, TextBox tbox3, ComboBox cmb2, List<Button> listBtns)
        {
            this.TboxFunctionName = tboxFunctionName;
            this.CountTboxInt = countTboxInt;
            this.BoolTF = boolTF;
            this.CmbTboxTboxTbox1 = cmbTboxTboxTbox1;
            this.Tbox1 = tbox1;
            this.Tbox2 = tbox2;
            this.Tbox3 = tbox3;
            this.Cmb2 = cmb2;
            this.ListBtns = listBtns;
        }
    }
}
