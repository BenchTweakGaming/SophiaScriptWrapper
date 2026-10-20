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
    public partial class Donate : Window
    {
        // Import variables
        string sScaleSelected = MainWindow.sScaleSelected;

        public Donate(string donateTitle)
        {
            InitializeComponent();
            
            // Remove extra character from beginning bug
            if (donateTitle.Substring(0, 1) == "_")
            {
                this.Title = donateTitle.Substring(1);
            }
            else
            {
                this.Title = donateTitle;
            }           
            
            tbDonate.Text = this.Title;

            // Viewbox
            this.Height = (145 + (double.Parse(MainWindow.currentSSWWindowScale.HeightAdjustInPixels))) * (double.Parse(sScaleSelected) / 100);
            this.Width = (270) * (double.Parse(sScaleSelected) / 100);
        }
        // Hyperlink explorer.exe
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {            
            System.Diagnostics.Process.Start("explorer.exe", e.Uri.ToString());
        }
    }
}
