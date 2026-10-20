using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SophiaScriptWrapper
{
    public class SSWFontScale
    {
        //public string Code { get; set; }
        public string Header { get; set; }
        public string LabelWidth { get; set; }       

        public SSWFontScale() // Constructor Blank
        {
            //
        }

        public SSWFontScale(string header, string labelWidth)
        {
            //this.Code = code;

            this.Header = header;

            this.LabelWidth = labelWidth;           
        }
        public void FontScaleFunction(object sender, EventArgs e)
        {
            //MainWindow.OSLanguage = this.Code.ToString().ToLower();

            MainWindow.currentSSWFontScale = this;




            ((MainWindow)System.Windows.Application.Current.MainWindow).FontScaleUI();
        }
    }
}

