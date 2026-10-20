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
    /// Interaction logic for Info.xaml
    /// </summary>
    public partial class Info3 : Window
    {
        string sTitle;

        string sHeader;

        // Current OS
        string sCurrentOSWindowsVersionNumber = "";

        bool bCurrentOSBoolLTSC = false;

        string sCurrentOSLTSCVersionNumber = "";

        string sCurrentOSCpuArch = "";

        // PS versions installed

        string sPowerShellVersion5_1Installed = "";
        string sPowerShellVersion7Installed = "";


        // Imported PS1
        string sImportedPS1WindowsVersionNumber = "";

        bool bImportedPS1BoolLTSC = false;

        string sImportedPS1LTSCVersionNumber = "";

        string sImportedPS1CpuArch = "";

        string sImportedPS1PowerShellVersionNumber = "";


        // Compatibility
        bool bWindowsVersionNumber = false;
        bool bLTSC = false;
        bool bLTSCVersion = false;
        bool bCpuArch = false;
        bool bPS5_1 = false;
        bool bPS7 = false;
        bool bPS = false;


        public Info3(string s)
        {
            InitializeComponent();

            //GetCurrentOS();

            GetPSVersionInstalled();

            //GetImportedPS1();

            DisplayCurrentOSInfo();

            DisplayPSVersionInstalledInfo();

            DisplayImportedPSInfo();

            if (sCurrentOSWindowsVersionNumber == sImportedPS1WindowsVersionNumber)
            {
                bWindowsVersionNumber = true;
            }
            if (bCurrentOSBoolLTSC == bImportedPS1BoolLTSC)
            {
                bLTSC = true;
                if (sCurrentOSLTSCVersionNumber == sImportedPS1LTSCVersionNumber)
                {
                    bLTSCVersion = true;
                }
            }
            //ModernWpf.MessageBox.Show(sCurrentOSCpuArch + ", " + sImportedPS1CpuArch);
            if (sCurrentOSCpuArch.ToLower().Trim() == sImportedPS1CpuArch.ToLower().Trim())
            {
                //ModernWpf.MessageBox.Show(sCurrentOSCpuArch + ", " + sImportedPS1CpuArch);

                bCpuArch = true;
            }

            if (sImportedPS1PowerShellVersionNumber.Contains("5"))
            {
                bPS5_1 = true;
            }
            if (sImportedPS1PowerShellVersionNumber.Contains("7"))
            {
                bPS7 = true;
            }

            if (sPowerShellVersion5_1Installed == "yes" & bPS5_1)
            {
                bPS = true;
            }
            if (sPowerShellVersion7Installed == "yes" & bPS7)
            {
                bPS = true;
            }

            //ModernWpf.MessageBox.Show(bWindowsVersionNumber.ToString() + ", " + bCurrentOSBoolLTSC.ToString() + ", " + )


            if (bWindowsVersionNumber & bCurrentOSBoolLTSC & bLTSCVersion & bCpuArch & bPS)
            {
                tblckCompatibility.Text = "Yes";
            }
            else if (bWindowsVersionNumber & bCpuArch & bPS)
            {
                tblckCompatibility.Text = "Yes";
            }
            else if (sImportedPS1WindowsVersionNumber != "")
            {
                tblckCompatibility.Text = "No";
            }
            else
            {
                tblckCompatibility.Text = "Nothing Imported.";
            }















        }
        //private void GetCurrentOS()
        //{
        //    // Check Current OS
        //    if (MainWindow.windowsOSVersion.Contains("10"))
        //    {
        //        sCurrentOSWindowsVersionNumber = "Windows 10";
        //    }
        //    else if (MainWindow.windowsOSVersion.Contains("11"))
        //    {
        //        sCurrentOSWindowsVersionNumber = "Windows 11";
        //    }

        //    if (MainWindow.bProductNameLTSC)
        //    {
        //        bCurrentOSBoolLTSC = true;
        //    }
        //    else
        //    {
        //        bCurrentOSBoolLTSC = false;
        //    }

        //    if (MainWindow.bProductName2019)
        //    {
        //        sCurrentOSLTSCVersionNumber = "2019";
        //    }
        //    if (MainWindow.bProductName2021)
        //    {
        //        sCurrentOSLTSCVersionNumber = "2021";
        //    }
        //    if (MainWindow.bProductName2024)
        //    {
        //        sCurrentOSLTSCVersionNumber = "2024";
        //    }

        //    sCurrentOSCpuArch = MainWindow.cpuArch;
        //}

        private void GetPSVersionInstalled()
        {
            sPowerShellVersion5_1Installed = MainWindow.powerShellVersion5_1Installed;
            sPowerShellVersion7Installed = MainWindow.powerShellVersion7Installed;

        }


        //private void GetImportedPS1()
        //{
        //    // Imported
        //    if (MainWindow.sImportedPS1SophiaWindowsVersionNumber.Contains("10"))
        //    {
        //        sImportedPS1WindowsVersionNumber = "Windows 10";
        //    }
        //    else if (MainWindow.sImportedPS1SophiaWindowsVersionNumber.Contains("11"))
        //    {
        //        sImportedPS1WindowsVersionNumber = "Windows 11";
        //    }

        //    if (MainWindow.sImportedPS1SophiaWindowsVersionNumber.Contains("LTSC"))
        //    {
        //        bImportedPS1BoolLTSC = true;
        //    }
        //    else
        //    {
        //        bImportedPS1BoolLTSC = false;
        //    }

        //    if (bImportedPS1BoolLTSC)
        //    {
        //        if (MainWindow.sImportedPS1SophiaWindowsVersionNumber.Contains("2019"))
        //        {
        //            sImportedPS1LTSCVersionNumber = "2019";
        //        }
        //        else if (MainWindow.sImportedPS1SophiaWindowsVersionNumber.Contains("2021"))
        //        {
        //            sImportedPS1LTSCVersionNumber = "2021";
        //        }
        //        else if (MainWindow.sImportedPS1SophiaWindowsVersionNumber.Contains("2024"))
        //        {
        //            sImportedPS1LTSCVersionNumber = "2024";
        //        }
        //    }

        //    if (MainWindow.sImportedPS1IsArm == "yes")
        //    {
        //        sImportedPS1CpuArch = "ARM64";
        //    }
        //    else
        //    {
        //        sImportedPS1CpuArch = "X64";
        //    }


        //    if (MainWindow.sImportedPS1PowerShellVersionNumber != "")
        //    {
        //        sImportedPS1PowerShellVersionNumber = MainWindow.sImportedPS1PowerShellVersionNumber;
        //    }
        //}

        private void DisplayCurrentOSInfo()
        {
            // Current OS
            if (bCurrentOSBoolLTSC)
            {
                tblckCurrentOS.Text = sCurrentOSWindowsVersionNumber + " LTSC " + sCurrentOSLTSCVersionNumber;
            }
            else if (sCurrentOSCpuArch.ToLower() == "arm64")
            {
                tblckCurrentOS.Text = sCurrentOSWindowsVersionNumber + " " + "ARM";
            }
            else
            {
                tblckCurrentOS.Text = sCurrentOSWindowsVersionNumber;
            }
        }

        private void DisplayPSVersionInstalledInfo()
        {
            string sPSV51 = "PS 5.1 Installed: ";
            string sPSV7 = "PS 7 Installed: ";

            if (sPowerShellVersion5_1Installed != "")
            {
                sPSV51 += sPowerShellVersion5_1Installed;
            }
            if (sPowerShellVersion7Installed != "")
            {
                sPSV7 += sPowerShellVersion7Installed;
            }

            tblckPowerShellVersionsInstalled.Text = sPSV51 + ", " + sPSV7;          
        }

        private void DisplayImportedPSInfo()
        {
            // Imported
            if (bImportedPS1BoolLTSC)
            {
                tblckImportedSophiaScript.Text = sImportedPS1WindowsVersionNumber + " LTSC " + sImportedPS1LTSCVersionNumber;
            }
            else if (sImportedPS1CpuArch.ToLower() == "arm64")
            {
                tblckImportedSophiaScript.Text = sImportedPS1WindowsVersionNumber + " " + "ARM";
            }
            else if (sImportedPS1WindowsVersionNumber != "")
            {
                tblckImportedSophiaScript.Text = sImportedPS1WindowsVersionNumber;
            }
            else
            {
                tblckImportedSophiaScript.Text = "Nothing Imported.";
            }
        }
    }
}
