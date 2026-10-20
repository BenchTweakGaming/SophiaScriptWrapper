using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SophiaScriptWrapper
{
    public class SSWToolTipScale
    {
        //public string Code { get; set; }
        public string Header { get; set; }
        //public string HeightAdjustInPixels { get; set; }

        public SSWToolTipScale() // Constructor Blank
        {
            //
        }

        //public SSWToolTipScale(string code, string header, string heightAdjustInPixels)
        public SSWToolTipScale(string header)
        {
            //this.Code = code;

            this.Header = header;

            //this.HeightAdjustInPixels = heightAdjustInPixels;
        }
        public void ToolTipScaleFunction(object sender, EventArgs e)
        {
            //MainWindow.OSLanguage = this.Code.ToString().ToLower();

            MainWindow.currentSSWToolTipScale = this;

            ((MainWindow)System.Windows.Application.Current.MainWindow).ToolTipScaleUI();
        }
    }
}

