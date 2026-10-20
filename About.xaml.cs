using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SophiaScriptWrapper
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Window
    {

        string sScaleSelected = MainWindow.sScaleSelected;

        public About(string aboutTitle)
        {
            InitializeComponent();
            
            // Remove extra character from beginning bug
            if (aboutTitle.Substring(0, 1) == "_")
            {
                this.Title = aboutTitle.Substring(1);
            }
            else
            {
                this.Title = aboutTitle;
            }

            
            // tbCopyright using fileversioninfo
            var fileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location);
            string sCopyright = fileVersionInfo.LegalCopyright;

            string startSCopyright = sCopyright.Substring(0, sCopyright.IndexOf ("©")+1);
            string endSCopyright = sCopyright.Substring(sCopyright.IndexOf("©")+1);

            string outputTbCopyright = startSCopyright + " 2020 -" + endSCopyright;

            tbCopyright.Text = outputTbCopyright;

            // Viewbox
            this.Height = (200 + (double.Parse(MainWindow.currentSSWWindowScale.HeightAdjustInPixels))) * (double.Parse(sScaleSelected) / 100);
            this.Width = (270) * (double.Parse(sScaleSelected) / 100);

            ///tbVersion.Text = "v" + MainWindow.SSWVersion;
        }
        // Hyperlink explorer.exe
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {            
            System.Diagnostics.Process.Start("explorer.exe", e.Uri.ToString());
        }
    }
}
