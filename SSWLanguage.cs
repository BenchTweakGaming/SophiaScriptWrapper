using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SophiaScriptWrapper
{
    public class SSWLanguage
    {
        public string Code { get; set; }
        public string Folder { get; set; }
        public string WidthOfWrapperInPixels { get; set; }
        public string HeightOfWrapperInPixels { get; set; }
        public string WidthLabelInPixels { get; set; }
        public string WidthLabelContextTabInPixels { get; set; }
        public string WidthComboBoxInPixels { get; set; }
        public string WidthComboBoxSystemTabInPixels { get; set; }
        public string WidthComboBoxStartMenuTabInPixels { get; set; }

        public SSWLanguage() // Constructor Blank
        {
            //
        }

        public SSWLanguage(string code, string folder, string widthOfWrapperInPixels, string heightOfWrapperInPixels, string widthLabelInPixels,
            string widthLabelContextTabInPixels, string widthComboBoxInPixels, string widthComboBoxSystemTabInPixels,
            string widthComboBoxStartMenuTabInPixels)
        {
            this.Code = code;

            this.Folder = folder;

            this.WidthOfWrapperInPixels = widthOfWrapperInPixels;

            this.HeightOfWrapperInPixels = heightOfWrapperInPixels;

            this.WidthLabelInPixels = widthLabelInPixels;

            this.WidthLabelContextTabInPixels = widthLabelContextTabInPixels;

            this.WidthComboBoxInPixels = widthComboBoxInPixels;

            this.WidthComboBoxSystemTabInPixels = widthComboBoxSystemTabInPixels;

            this.WidthComboBoxStartMenuTabInPixels = widthComboBoxStartMenuTabInPixels;
        }
        public void LanguageFunction(object sender, EventArgs e)
        {
            MainWindow.OSLanguage = this.Code.ToString().ToLower();

            MainWindow.currentSSWLanguage = this;

            ((MainWindow)System.Windows.Application.Current.MainWindow).RevertBackToPreviousToolTipScale();

            ((MainWindow)System.Windows.Application.Current.MainWindow).OnGoingWrapperWindowScale();         

            ((MainWindow)System.Windows.Application.Current.MainWindow).ChangeToolTipsTagsUIForCurrentLanguage();

            ((MainWindow)System.Windows.Application.Current.MainWindow).GetCurrentScaleAndCreateCurrentScaleInNewLanguageAndScaleUI();
        }
    }
}

