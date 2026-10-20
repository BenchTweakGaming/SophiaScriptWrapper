using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SophiaScriptWrapper
{
    public class SSWWindowScale
    {
        public string Code { get; set; }
        public string Header { get; set; }
        public string HeightAdjustInPixels { get; set; }

        public SSWWindowScale() // Constructor Blank
        {
            //
        }

        public SSWWindowScale(string code, string header, string heightAdjustInPixels)
        {
            this.Code = code;

            this.Header = header;

            this.HeightAdjustInPixels = heightAdjustInPixels;
        }
        public void WindowScaleFunction(object sender, EventArgs e)
        {
            //MainWindow.OSLanguage = this.Code.ToString().ToLower();

            MainWindow.currentSSWWindowScale = this;

            ((MainWindow)System.Windows.Application.Current.MainWindow).ScaleUI();
        }
    }
}

