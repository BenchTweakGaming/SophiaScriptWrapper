using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SophiaScriptWrapper
{
    /// <summary>
    /// Interaction logic for TestOutputWindow.xaml
    /// </summary>
    public partial class TestOutputWindow : Window
    {
        string sOutput = "";
        public TestOutputWindow(string sTitle, int width, int height, string sInput)
        {
            InitializeComponent();

            this.Title = sTitle;

            this.sOutput = sInput;

            tbOutput.Text = sOutput;

            this.Height = height;
            this.Width = width;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
