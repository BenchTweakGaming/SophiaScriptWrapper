using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Windows.Networking.NetworkOperators;
using Windows.UI.Xaml;
using Application = System.Windows.Application;

namespace SophiaScriptWrapper
{
    public class Section
    {
        //public static MainWindow wnd = new MainWindow();

        // Input
        public string FindString { get; set; } // What to find

        // Select
        public string SelectString { get; set; }
        public List<string> SelectList { get; set; }

        // ToolTip
        public string ToolTipString { get; set; }
        public List<string> ToolTipList { get; set; }
        public Dictionary<string, string> ToolTipDict { get; set; }

        // CONTROLS
        // RadioButtons
        public List<RadioButton> RadioButtons { get; set; }
        // ComboBoxes
        public List<ComboBox> ComboBoxes { get; set; }
        // Labels
        public List<Label> Labels { get; set; }

        // Label for ToolTip Dict
        public Dictionary<string, string> LabelToolTipDict { get; set; }

        // CheckBoxes
        public List<CheckBox> CheckBoxes { get; set; }
        // Dictionary String List Checkboxes
        public Dictionary<string, List<CheckBox>> DictStringListChk { get; set; }
        // Special List CheckBox
        //public List<CheckBox> SListChk { get; set; }
        // Special Dictionary String List String
        public Dictionary<string, List<string>> SDictStringListString { get; set; }

        // DNSoverHTTPS
        public Dictionary<string, List<ComboBox>> DictStringListCmbDOH { get; set; }
        public Dictionary<string, List<string>> SelectDictStringListCmbDOH { get; set; }

        // PESC Edge
        public Dictionary<string, List<CheckBox>> DictStringListChk2PESC { get; set; }
        public Dictionary<string, List<string>> SelectDictStringListString2PESC { get; set; } // Not used as this.SelectList is used

        // Sophia region line by line in list
        public List<string> RegionAllLinesList { get; set; } // Not used

        // All functions and argument list
        public List<string> AllFunctionsList { get; set; }

        // All functions and argument list
        public List<string> AllFunctionsListWithCombos { get; set; }

        // Commented (unselect) List
        public List<string> CommentedUnselectedList { get; set; }

        // Uncommented (select) List
        public List<string> UncommentedSelectedList { get; set; }

        // Set-Association    
        public Dictionary<string, List<string>> SelectDictStringListStringSA { get; set; }

        // UserFolders    //list of this // Mozilla
        public Dictionary<string, string> SelectDictStringStringUF { get; set; }


        // Special Functions list string        
        public List<string> ListStringSpecialFunctions { get; set; }

        // List Cmbcmb for like UserFolders
        public List<Cmbs> ListCmbsUF { get; set; }

        // List Tboxtboxtbox for Set-Association
        public List<Tboxtboxtbox> ListTboxtboxtboxSA { get; set; }

        // List Cmbcmbcmb for like DNSoverHTTPS
        public List<Cmbcmbcmb> ListCmbcmbcmbDOH { get; set; }

        // List Cmbtag for Special Functions
        public List<Cmbtag> ListCmbtagSF { get; set; }


        // List Cmbchk for Prevent Edge Shortcut Creation
        public List<Cmbchk> ListCmbchkPESC { get; set; }

        // List of Just function names
        public List<string> ListStringFunctionNamesOnly { get; set; }

        // List of Just function names that need own tooltip
        public List<string> ListStringFunctionNamesThatNeedOwnToolTip { get; set; }

        // Dictionary of Special Functions
        public Dictionary<string, bool> DictStringBooleanSpecialFunctions { get; set; }

        // List of Required for IntitalActions
        public List<CmbRequired> ListCmbRequiredIA { get; set; }

        // List of Cmbchkalter for OneDrive -AllUsers
        public List<Cmbchkalter> ListCmbchkalterODAU { get; set; }

        // List of Chkchkalter for UWP ForAllUsers
        public List<Chkchkalter> ListChkchkalterUWPFAU { get; set; }

        // End String
        public string EndString { get; set; } // End region

        public Section() // Constructor Blank
        {
            //
        }

        public Section(string findString, string selectString, List<string> selectList,
            string toolTipString, List<string> toolTipList, Dictionary<string, string> toolTipDict, List<RadioButton> radioButtons,
            List<ComboBox> comboBoxes, List<Label> labels, Dictionary<string, string> labelToolTipDict, List<CheckBox> checkBoxes,
            Dictionary<string, List<CheckBox>> dictStringListChk, Dictionary<string, List<string>> sDictStringListString,
            Dictionary<string, List<ComboBox>> dictStringListCmbDOH, Dictionary<string, List<string>> selectDictStringListCmbDOH,
            Dictionary<string, List<CheckBox>> dictStringListChkPESC, Dictionary<string, List<string>> selectDictStringListStringPESC, List<string> regionAllLinesList,
            List<string> allFunctionsList, List<string> allFunctionsListWithCombos, List<string> commentedUnselectedList, List<string> uncommentedSelectedList, Dictionary<string, List<string>> selectDictStringListStringSA,
            Dictionary<string, string> selectDictStringStringUF, List<string> listStringSpecialFunctions, List<Cmbs> listCmbcmb, List<Tboxtboxtbox> listTboxtboxtbox,
            List<Cmbcmbcmb> listCmbcmbcmb, List<Cmbtag> listCmbtag, List<Cmbchk> listCmbchk, List<string> listJustFunctionNames, List<string> listStringFunctionNamesThatNeedOwnToolTip,
            Dictionary<string, bool> dictStringBooleanFunctionTag, List<CmbRequired> listRequired, List<Cmbchkalter> listCmbchkalter, List<Chkchkalter> listChkchkalter, string endString)
        {
            this.FindString = findString;

            //Select
            this.SelectString = selectString;
            this.SelectList = selectList;
            //ToolTip
            this.ToolTipString = toolTipString;
            this.ToolTipList = toolTipList;
            this.ToolTipDict = toolTipDict;

            //Radiobuttons
            this.RadioButtons = radioButtons;

            //ComboBoxs
            this.ComboBoxes = comboBoxes;

            //Labels
            this.Labels = labels;

            // Label ToolTipDict
            this.LabelToolTipDict = labelToolTipDict;

            // CheckBoxs
            this.CheckBoxes = checkBoxes;

            // Dictionary strings of list of strings
            this.DictStringListChk = dictStringListChk;

            // CheckBoxs
            //this.SListChk = sListChk;
            //Select
            this.SDictStringListString = sDictStringListString;

            // Combo of 2 comboboxes DNS
            this.DictStringListCmbDOH = dictStringListCmbDOH;
            this.SelectDictStringListCmbDOH = selectDictStringListCmbDOH;

            // Checkbox of Edge
            this.DictStringListChk2PESC = dictStringListChkPESC;
            this.SelectDictStringListString2PESC = selectDictStringListStringPESC;

            // Saving all comments
            this.RegionAllLinesList = regionAllLinesList; // Not used
            this.AllFunctionsList = allFunctionsList;
            this.AllFunctionsListWithCombos = allFunctionsListWithCombos;
            this.CommentedUnselectedList = commentedUnselectedList;
            this.UncommentedSelectedList = uncommentedSelectedList;

            // Set-Association
            this.SelectDictStringListStringSA = selectDictStringListStringSA;

            // UserFolders
            this.SelectDictStringStringUF = selectDictStringStringUF;

            this.ListStringSpecialFunctions = listStringSpecialFunctions;

            // Cmbcmb for UserFolders
            this.ListCmbsUF = listCmbcmb;

            // Tboxtboxtbox for Set-Association
            this.ListTboxtboxtboxSA = listTboxtboxtbox;

            // Cmbcmbcmb for DNSoverHTTPS
            this.ListCmbcmbcmbDOH = listCmbcmbcmb;

            // Cmbcmbcmb for Special Functions
            this.ListCmbtagSF = listCmbtag;

            // Cmbcmbcmb for Prevent Edge Shortcut Creation
            this.ListCmbchkPESC = listCmbchk;

            // List of just funciton names
            this.ListStringFunctionNamesOnly = listJustFunctionNames;

            // List of just funciton names
            this.ListStringFunctionNamesThatNeedOwnToolTip = listStringFunctionNamesThatNeedOwnToolTip;

            // Dictionary string bool Special Functions

            this.DictStringBooleanSpecialFunctions = dictStringBooleanFunctionTag;

            // List of Required for IntialActions
            this.ListCmbRequiredIA = listRequired;

            // List of Cmbchkalter for OneDrive -AllUsers
            this.ListCmbchkalterODAU = listCmbchkalter;

            // List of Chkchkalter for UWP -ForAllUsers
            this.ListChkchkalterUWPFAU = listChkchkalter;

            //End
            this.EndString = endString;
        }

        // Function: Make List from FirstString using split function
        //public void MakeList()
        //{
        //    this.StringList = this.FirstString.Split(';').ToList();
        //}

        // Function: Make Select list from Select String using split function
        public void MakeSelectList()
        {
            this.SelectList = new List<string>();
            this.SelectList = this.SelectString.Split(';').ToList();
        
        
        
        
        }

        // Function: Make Select Dict List Special
        public void MakeSelectDictList()
        {
            this.SDictStringListString = new Dictionary<string, List<string>>(); // Normal Stuff
            this.SelectDictStringListCmbDOH = new Dictionary<string, List<string>>();

            //string fstring1OneDrive = "OneDrive";
            //string fstring2OneDriveFileExplorerAd = "OneDriveFileExplorerAd";

            // Contains this PESC
            bool containsPESC = false;
            List<string> listStringPESCToAddToSelectList = new List<string>();

            // booleans for OneDrive option
            //bool addOneDriveInstall = false;
            //bool addOneDriveAllUsers = false;
            List<string> listStringOneDriveToAddToSelectList = new List<string>();

            foreach (string s in this.SelectList)
            {
                for (int a = 0; a < this.ListCmbchkalterODAU.Count; a++)
                {
                    //string fstringallusers = this.ListCmbchkalter[a].ChkFunctionName.Substring(0, this.ListCmbchkalter[a].ChkFunctionName.IndexOf(" "));
                    string fstringallusers = this.ListCmbchkalterODAU[a].CmbFunctionName + " -" + this.ListCmbchkalterODAU[a].LstStrMainArg[this.ListCmbchkalterODAU[a].IndexOfInstall] + " -" + MainWindow.ReturnLastPartFromInput(this.ListCmbchkalterODAU[a].ChkFunctionName);

                    //ModernWpf.MessageBox.Show(s + " : " + fstringallusers);

                    if (s.Contains(fstringallusers))
                    {
                        // If does not contain OneDrive -Install, then include it
                        if (!this.SelectList.Contains(this.ListCmbchkalterODAU[a].CmbFunctionName + " -" + this.ListCmbchkalterODAU[a].LstStrMainArg[this.ListCmbchkalterODAU[a].IndexOfInstall]))
                        {
                            listStringOneDriveToAddToSelectList.Add(this.ListCmbchkalterODAU[a].CmbFunctionName + " -" + this.ListCmbchkalterODAU[a].LstStrMainArg[this.ListCmbchkalterODAU[a].IndexOfInstall]);
                            //addOneDriveInstall = true; // Use for later on bottom of function
                        }
                        // If does not contain OneDrive -AllUsers, then include it
                        if (!this.SelectList.Contains(this.ListCmbchkalterODAU[a].ChkFunctionName))
                        {
                            listStringOneDriveToAddToSelectList.Add(this.ListCmbchkalterODAU[a].ChkFunctionName);
                            //addOneDriveAllUsers = true; // Use for later on bottom of function
                        }
                    }
                }

                for (int a = 0; a < this.ListCmbsUF.Count; a++)
                {
                    string fstringuf = this.ListCmbsUF[a].CmbFunctionName;

                    if (s.Contains(fstringuf))
                    {
                        // list of string for string in selectString
                        List<string> v = new List<string>();

                        // split s to list into v
                        v = s.Split(' ').ToList();

                        // All filled
                        if (v.Count > 14)
                        {
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[1], v[2]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[3], v[4]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[5], v[6]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[7], v[8]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[9], v[10]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[11], v[12]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[13], v[14]);
                        }
                        else if (v.Count > 12)
                        {
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[1], v[2]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[3], v[4]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[5], v[6]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[7], v[8]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[9], v[10]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[11], v[12]);
                        }
                        else if (v.Count > 10)
                        {
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[1], v[2]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[3], v[4]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[5], v[6]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[7], v[8]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[9], v[10]);
                        }
                        else if (v.Count > 8)
                        {
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[1], v[2]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[3], v[4]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[5], v[6]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[7], v[8]);
                        }
                        else if (v.Count > 6)
                        {
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[1], v[2]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[3], v[4]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[5], v[6]);
                        }
                        else if (v.Count > 4)
                        {
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[1], v[2]);
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[3], v[4]);
                        }
                        else if (v.Count > 2)
                        {
                            this.SelectDictStringStringUF.Add(v[0] + " " + v[1], v[2]);
                        }
                        else // SophiaPreset or WindowsDefaultPreset
                        {
                            string s1string = "";

                            string s1_1 = this.ListCmbsUF[a].LstStrMainArg[0];

                            List<ComboBox> s1_2 = this.ListCmbsUF[a].LstCmb1;

                            List<string> s1_3 = new List<string>();

                            foreach (ComboBox cmb in s1_2)
                            {
                                int selectedIndex = 0;
                                ComboBoxItem cmbitem = (ComboBoxItem)cmb.Items.GetItemAt(selectedIndex);

                                if (cmbitem != null)
                                {
                                    s1_3.Add(cmbitem.Tag.ToString());
                                }
                            }

                            s1string += fstringuf + " ";

                            foreach (string ufs in s1_3)
                            {
                                s1string += ufs.Substring(ufs.IndexOf(" ")).Trim();
                                s1string += " ";
                            }

                            s1string = s1string.Trim();

                            string s2string = "";

                            string s2_1 = this.ListCmbsUF[a].LstStrMainArg[1];

                            s2string += fstringuf + " ";

                            foreach (string ufs in s1_3)
                            {
                                s2string += ufs.Substring(ufs.IndexOf(" ")).Trim();
                                s2string += " ";
                            }

                            s2string = s2string.Trim();

                            // Show
                            string shide = fstringuf + " -" + s1_1;
                            string sshow = fstringuf + " -" + s2_1;

                            if (s == shide)
                            {
                                List<string> vh = new List<string>();

                                vh = s1string.Split(' ').ToList();

                                if (!this.SelectDictStringStringUF.ContainsKey(vh[0] + " " + vh[1]))
                                {
                                    this.SelectDictStringStringUF.Add(vh[0] + " " + vh[1], vh[2]);
                                }
                                if (vh.Count > 3)
                                {
                                    if (!this.SelectDictStringStringUF.ContainsKey(vh[0] + " " + vh[3]))
                                    {
                                        this.SelectDictStringStringUF.Add(vh[0] + " " + vh[3], vh[4]);
                                    }
                                }
                                if (vh.Count > 5)
                                {
                                    if (!this.SelectDictStringStringUF.ContainsKey(vh[0] + " " + vh[5]))
                                    {
                                        this.SelectDictStringStringUF.Add(vh[0] + " " + vh[5], vh[6]);
                                    }
                                }
                                if (vh.Count > 7)
                                {
                                    if (!this.SelectDictStringStringUF.ContainsKey(vh[0] + " " + vh[7]))
                                    {
                                        this.SelectDictStringStringUF.Add(vh[0] + " " + vh[7], vh[8]);
                                    }
                                }
                                if (vh.Count > 9)
                                {
                                    if (!this.SelectDictStringStringUF.ContainsKey(vh[0] + " " + vh[9]))
                                    {
                                        this.SelectDictStringStringUF.Add(vh[0] + " " + vh[9], vh[10]);
                                    }
                                }
                                if (vh.Count > 11)
                                {
                                    if (!this.SelectDictStringStringUF.ContainsKey(vh[0] + " " + vh[11]))
                                    {
                                        this.SelectDictStringStringUF.Add(vh[0] + " " + vh[11], vh[12]);
                                    }
                                }
                                if (vh.Count > 13)
                                {
                                    if (!this.SelectDictStringStringUF.ContainsKey(vh[0] + " " + vh[13]))
                                    {
                                        this.SelectDictStringStringUF.Add(vh[0] + " " + vh[13], vh[14]);
                                    }
                                }
                            }

                            // Hide
                            else if (s == sshow)
                            {
                                List<string> vs = new List<string>();

                                vs = s2string.Split(' ').ToList();

                                if (!this.SelectDictStringStringUF.ContainsKey(vs[0] + " " + vs[1]))
                                {
                                    this.SelectDictStringStringUF.Add(vs[0] + " " + vs[1], vs[2]);
                                }
                                if (vs.Count > 3)
                                {
                                    if (!this.SelectDictStringStringUF.ContainsKey(vs[0] + " " + vs[3]))
                                    {
                                        this.SelectDictStringStringUF.Add(vs[0] + " " + vs[3], vs[4]);
                                    }
                                }
                                if (vs.Count > 5)
                                {
                                    if (!this.SelectDictStringStringUF.ContainsKey(vs[0] + " " + vs[5]))
                                    {
                                        this.SelectDictStringStringUF.Add(vs[0] + " " + vs[5], vs[6]);
                                    }
                                }
                                if (vs.Count > 7)
                                {
                                    if (!this.SelectDictStringStringUF.ContainsKey(vs[0] + " " + vs[7]))
                                    {
                                        this.SelectDictStringStringUF.Add(vs[0] + " " + vs[7], vs[8]);
                                    }
                                }
                                if (vs.Count > 9)
                                {
                                    if (!this.SelectDictStringStringUF.ContainsKey(vs[0] + " " + vs[9]))
                                    {
                                        this.SelectDictStringStringUF.Add(vs[0] + " " + vs[9], vs[10]);
                                    }
                                }
                                if (vs.Count > 11)
                                {
                                    if (!this.SelectDictStringStringUF.ContainsKey(vs[0] + " " + vs[11]))
                                    {
                                        this.SelectDictStringStringUF.Add(vs[0] + " " + vs[11], vs[12]);
                                    }
                                }
                                if (vs.Count > 13)
                                {
                                    if (!this.SelectDictStringStringUF.ContainsKey(vs[0] + " " + vs[13]))
                                    {
                                        this.SelectDictStringStringUF.Add(vs[0] + " " + vs[13], vs[14]);
                                    }
                                }
                            }
                        }
                    }
                }

                // Set-Assocation

                for (int i = 0; i < this.ListTboxtboxtboxSA.Count; i++)
                {
                    string fstring5SetAssociation = this.ListTboxtboxtboxSA[i].TboxFunctionName;
                    int saCounter = 0;

                    foreach (var item in this.SelectDictStringListStringSA)
                    {
                        if (item.Key.Contains(fstring5SetAssociation))
                        {
                            saCounter++;
                        }
                    }

                    // string k for key in dictionary
                    string k = "";
                    // list of string for split string in SelectString
                    List<string> v = new List<string>();

                    // Key is fstring5SetAssociation
                    k = fstring5SetAssociation;

                    if (s.Contains(k))
                    {
                        // Split string in SelectString
                        v = s.Split(' ').ToList();

                        // Hold location of quotes in list of string v
                        List<int> locationOfQuotes = new List<int>();
                        int locationOfExtension = 0;

                        // Find where the quotes in list v
                        for (int p = 0; p < v.Count; p++)
                        {
                            // find quote
                            if (v[p].Contains("\""))
                            {
                                // Add location of quote
                                locationOfQuotes.Add(p);
                            }
                            // find extension
                            if (v[p].Contains("-Extension"))
                            {
                                // Add location of quote
                                locationOfExtension = p;
                            }
                        }

                        // values for Dictionary
                        List<string> tv = new List<string>();

                        if (locationOfQuotes.Count == 0)
                        {
                            if (v.Count == 7)
                            {
                                // string ProgramPath
                                string spp = "";
                                spp += v[2];
                                tv.Add(spp.Trim());

                                // string Extension
                                tv.Add(v[4]);

                                // string ico
                                tv.Add(v[6]);
                            }
                            else if (v.Count == 5)
                            {
                                // string ProgramPath
                                string spp = "";
                                spp += v[2];
                                tv.Add(spp.Trim());

                                // string Extension
                                tv.Add(v[4]);
                            }
                        }

                        else if (locationOfQuotes.Count > 0)
                        {
                            // 4 quotes
                            if (locationOfQuotes.Count >= 4)
                            {
                                // string ProgramPath
                                string spp = "";
                                for (int p = locationOfQuotes[0]; p < locationOfQuotes[1] + 1; p++)
                                {
                                    spp += v[p] + " ";
                                }
                                tv.Add(spp.Trim());

                                // string Extension
                                tv.Add(v[locationOfQuotes[1] + 2]);

                                // string Ico
                                string sico = "";
                                for (int p = locationOfQuotes[2]; p < locationOfQuotes[3] + 1; p++)
                                {
                                    sico += v[p] + " ";
                                }
                                tv.Add(sico.Trim());
                            }
                            // 3 quotes
                            else if ((locationOfQuotes.Count == 3) & (v.Count > 7))
                            {
                                // Extension ahead of two quotes
                                if (locationOfExtension > locationOfQuotes[1])
                                {
                                    // string ProgramPath
                                    string spp = "";
                                    for (int p = locationOfQuotes[0]; p < locationOfQuotes[1] + 1; p++)
                                    {
                                        spp += v[p] + " ";
                                    }
                                    tv.Add(spp.Trim());

                                    // string Extension
                                    tv.Add(v[locationOfQuotes[1] + 2]);

                                    // string Ico
                                    string sico = "";
                                    sico += v[locationOfQuotes[2]];
                                    tv.Add(sico.Trim());
                                }
                                // Extension behind 2 quotes
                                else
                                {
                                    // string ProgramPath
                                    string spp = "";
                                    spp = v[locationOfQuotes[0]];
                                    tv.Add(spp.Trim());

                                    // string Extension
                                    tv.Add(v[locationOfQuotes[0] + 2]);

                                    // string Ico
                                    string sico = "";
                                    for (int p = locationOfQuotes[1]; p < locationOfQuotes[2] + 1; p++)
                                    {
                                        sico += v[p] + " ";
                                    }
                                    tv.Add(sico.Trim());
                                }
                            }

                            // Two quotes

                            else if ((locationOfQuotes.Count == 2) & (v.Count >= 7))
                            {
                                // string ProgramPath
                                string spp = "";
                                for (int p = locationOfQuotes[0]; p < locationOfQuotes[1] + 1; p++)
                                {
                                    spp += v[p] + " ";
                                }
                                tv.Add(spp.Trim());

                                // string Extension
                                tv.Add(v[locationOfQuotes[1] + 2]);

                                if (v.Count > locationOfQuotes[1] + 4)
                                {
                                    string sico = "";
                                    for (int p = locationOfQuotes[1] + 4; p < v.Count; p++)
                                    {
                                        sico += v[p] + " ";
                                    }
                                    tv.Add(sico.Trim());
                                }
                            }
                            else if ((locationOfQuotes.Count == 2) & (v.Count == 6))
                            {
                                // string ProgramPath
                                string spp = "";
                                for (int p = locationOfQuotes[0]; p < locationOfQuotes[1] + 1; p++)
                                {
                                    spp += v[p] + " ";
                                }
                                tv.Add(spp.Trim());

                                // string Extension
                                tv.Add(v[locationOfQuotes[1] + 2]);

                                //string sico = "";
                                //sico += v[6];
                                //tv.Add(sico.Trim());
                            }
                            // For just ProgramPath and Extension and Ico when there is no spaces
                            //else if ((locationOfQuotes.Count == 2) & (v.Count == 7))
                            //{
                            //    // string ProgramPath
                            //    string spp = "";
                            //    spp = v[2];
                            //    tv.Add(spp.Trim());

                            //    // string Extension
                            //    tv.Add(v[4]);

                            //    string sico = "";
                            //    sico += v[6];
                            //    tv.Add(sico.Trim());
                            //}
                            // Just 2, ProgramPath and Extension with spaces
                            //else if ((locationOfQuotes.Count == 2) & (v.Count >= 6))
                            //{
                            //    // string ProgramPath
                            //    string spp = "";

                            //    for (int p = locationOfQuotes[0]; p < locationOfQuotes[1] + 1; p++)
                            //    {
                            //        spp += v[p] + " ";
                            //    }
                            //    tv.Add(spp.Trim());

                            //    // string Extension
                            //    tv.Add(v[locationOfQuotes[1] + 2]);
                            //}
                            // No spaces and just 2, ProgramPath and Extension
                            else if ((locationOfQuotes.Count == 1) & (v.Count == 5))
                            {
                                // string ProgramPath
                                string spp = "";
                                spp += v[2];
                                tv.Add(spp.Trim());

                                // string Extension
                                tv.Add(v[4]);
                            }

                        }

                        if (tv.Count > 0)
                        {
                            {
                                List<string> listdictionarywithoutnumber = new List<string>();

                                foreach (var item in this.SelectDictStringListStringSA)
                                {
                                    string keywithoutnumber = item.Key.Substring(0, item.Key.LastIndexOf("-"));

                                    keywithoutnumber = keywithoutnumber.Trim();

                                    string value = String.Join(", ", item.Value.ToArray());

                                    string kv = keywithoutnumber + ":" + value;

                                    listdictionarywithoutnumber.Add(kv);
                                }

                                saCounter++;

                                string sakeydict = k + "-" + saCounter.ToString();

                                string ktvcreated = k + ":" + String.Join(", ", tv.ToArray());

                                if (!listdictionarywithoutnumber.Contains(ktvcreated))
                                {
                                    this.SelectDictStringListStringSA.Add(sakeydict, tv);
                                }
                            }
                        }
                    }
                }

                // DNSoverHTTPS
                for (int i = 0; i < this.ListCmbcmbcmbDOH.Count; i++)
                {
                    string accessString = this.ListCmbcmbcmbDOH[i].CmbFunctionName;

                    if (s.Contains(accessString))
                    {
                        string k = "";
                        List<string> v = new List<string>();

                        k = accessString;
                        v = s.Split(' ').ToList();

                        List<string> tv = new List<string>();
                        tv.Add(k + " " + v[1]);
                        if (v.Count > 2)
                        {
                            tv.Add(k + " -" + v[3]);
                            tv.Add(k + " -" + v[5]);
                        }

                        // Add to Select Dict
                        if (!SelectDictStringListCmbDOH.ContainsKey(k))
                        {
                            this.SelectDictStringListCmbDOH.Add(k, tv);
                        }

                    }

                }

                // PESC                   
                for (int k = 0; k < this.ListCmbchkPESC.Count; k++)
                {
                    // Get objects                        
                    string accessString = this.ListCmbchkPESC[k].CmbFunctionName;
                    List<string> accessListString = this.ListCmbchkPESC[k].LstStrMainArg;
                    List<string> accessListString2 = this.ListCmbchkPESC[k].LstStrChkArg;
                    bool accessBool = false;
                    int accessInt = this.ListCmbchkPESC[k].IndexOfMainArg;

                    // Does select list contain the function name without addition functions or tags???
                    if (s.Contains(accessString))
                    {
                        // bool to say yes it contain the special function
                        accessBool = true;

                        // Create a list to look for channels in PESC
                        List<string> listStringV = new List<string>();
                        // Split 
                        listStringV = s.Split(',').ToList();

                        // Channels
                        // got through the string list of chunks
                        foreach (string item in listStringV)
                        {
                            // For loop to look for addition function -function in this list. Usually 2 Channels or Disable
                            for (int j = 0; j < accessListString.Count; j++)
                            {
                                // If the object string contains one of the -functions. like Channels or Disable
                                if (item.Contains(accessListString[j]))
                                {
                                    // accessInt contains the either Channels or Disable spot. Like 0 or 1
                                    accessInt = j;

                                    // Global variable saying that this special function exists to bool true.
                                    containsPESC = accessBool;

                                    string stringFunctionAndHypenFunction = accessString + " -" + accessListString[j];
                                    // Add to global list to add this function later into this.SelectList
                                    listStringPESCToAddToSelectList.Add(stringFunctionAndHypenFunction);
                                }
                            }
                        }

                        // If contains channels. If the accessInt is the first hypen function which is Channels or enable. The first one
                        if (accessInt == 0)
                        {
                            // Select first channel string "XYZ," in list
                            string firstChannelString = listStringV[0].Substring(listStringV[0].LastIndexOf(" ")).Trim();
                            // Add to v2 list                                

                            // Fix Add to SelectList
                            string stringFunctionAndHypenChannel = accessString + " -" + firstChannelString;
                            // Add to global list to add this function later into this.SelectList
                            listStringPESCToAddToSelectList.Add(stringFunctionAndHypenChannel);

                            // If there is more Channels
                            // Add other channels
                            if (listStringV.Count > 0)
                            {
                                // for loop to add skip 1
                                foreach (string channelString in listStringV.Skip(1))
                                {
                                    // Create functionandhypenchannel to add to global list and then to this.selectList later
                                    stringFunctionAndHypenChannel = accessString + " -" + channelString.Trim();
                                    // Add to global list to add to this.selectlist later
                                    listStringPESCToAddToSelectList.Add(stringFunctionAndHypenChannel);
                                }
                            }
                        }
                    }
                }

                // NORMAL STUFF: Rest of normal select items 
                string kNormal = "";
                List<string> vNormal = new List<string>();

                // if string has more than 2 spaces break it up into a special list for dictionary. Many checkboxes
                if (twoSpacesOrMore(s) == true)
                {
                    kNormal = s.Substring(0, s.IndexOf(" ", s.IndexOf(" ") + 1));
                    vNormal = s.Substring(s.IndexOf(" ", s.IndexOf(" ") + 1)).Split(',').ToList();

                    List<string> listOfStringValues = new List<string>();

                    foreach (string stringV in vNormal)
                    {
                        listOfStringValues.Add(stringV.Trim());
                    }

                    if (!this.SDictStringListString.ContainsKey(kNormal))
                    {
                        this.SDictStringListString.Add(kNormal, listOfStringValues);
                    }
                }

            }
            // The special function is found either enabled or disabled so now add the global list to  this.selectlist
            if (containsPESC == true)
            {
                // Add channels strings
                foreach (string s in listStringPESCToAddToSelectList)
                {
                    this.SelectList.Add(s);
                }
            }

            // OneDrive add
            foreach (string s in listStringOneDriveToAddToSelectList)
            {
                this.SelectList.Add(s);
            }

            //// Add onedriveinstall
            //if (addOneDriveInstall == true)
            //{
            //    this.SelectList.Add("OneDrive -Install");
            //}
            //// Add onedrive allusers
            //if (addOneDriveAllUsers == true)
            //{
            //    this.SelectList.Add("OneDrive -AllUsers");
            //}
        }

        // Function: spaces boolean if 2 or more in string
        public bool twoSpacesOrMore(string str)
        {
            int spaceCounter = 0;
            string string1;

            for (int i = 0; i < str.Length; i++)
            {
                string1 = str.Substring(i, 1);
                if (string1 == " ")
                    spaceCounter++;
            }

            if (spaceCounter >= 2)
            {
                return true;
            }

            return false;
        }

        // Function: Make PS1 to SelectList
        public void MakePS1SelectList()
        {
            // Empty SelectList
            this.SelectList = new List<string>();

            // Make list from SelectString split by returns
            string[] lines = this.SelectString.Split(
                new[] { "\r\n", "\r", "\n" },
                StringSplitOptions.None
                );

            // Convert list above to normal List

            List<String> tempList = lines.OfType<string>().ToList();

            // Compare and Show Rename tempList to tempList1
            //List<String> tempList = new List<String>();

            //foreach (string line in tempList1)
            //{
            //    if (!MainWindow.listStrStringsToIgnoreInPS1.Contains(line))
            //    {
            //        tempList.Add(line);
            //    }
            //}           


            // For loop
            foreach (string s in tempList)
            {
                // Add line by line to list for saving Sophia.ps1 - Not used
                // this.RegionAllLinesList.Add(s);

                // If s is not empty
                if (s != "")
                {
                    // Other
                    string s2 = s; // no trim
                    string s3 = s2[0].ToString(); // Get first character

                    // If first character is not these then add to SelectList
                    if (s3 != "#" & s3 != "\t" & s3 != "<")
                    {
                        this.SelectList.Add(s.Trim());
                    }
                }
            }
        }

        // Function: Make ToolTip list to List with semicolon
        public void MakeToolTipList()
        {
            this.ToolTipList = this.ToolTipString.Split(';').ToList();
        }

        // Function: List to Dictionary
        public void ListToDict()
        {
            for (int i = 0; i < (this.ToolTipList.Count() - 1); i += 2)
            {
                if (!this.ToolTipDict.ContainsKey(this.ToolTipList[i]))
                {
                    this.ToolTipDict.Add(this.ToolTipList[i].ToString(), this.ToolTipList[i + 1].ToString());
                    //if (this.ToolTipList[i].Contains("ProgramPath"))
                    //{
                    //    ModernWpf.MessageBox.Show(this.ToolTipList[i] + ":" + this.ToolTipList[i + 1]);
                    //}
                }
            }
        }

        // Function: Make Label tooltip dictionary
        public void MakeLabelDict()
        {
            // Special list has a " -" in it so it can label it because normal function don't have space dash
            //List<string> specialList = new List<string>() { "OneDrive -AllUsers" };// { "PinToStart -Tiles", "PinToStart -Tiles ControlPanel" , "PinToStart -Tiles DevicesPrinters",            
            List<string> specialList = new List<string>();

            specialList.AddRange(this.ListStringSpecialFunctions);

            //// Can not figure out why add this manually
            //if (!specialList.Contains("UninstallUWPApps -ForAllUsers"))
            //{
            //    //specialList.Add("UninstallUWPApps -ForAllUsers");
            //}

            //if (specialList.Contains("UninstallUWPApps -ForAllUsers"))
            //{
            //    ModernWpf.MessageBox.Show("UninstallUWPApps -ForAllUsers");
            //}

            ////if (!specialList.Contains("Install-WSL"))
            //{
            //    //ModernWpf.MessageBox.Show( this.ToolTipDict["Install-WSL"]);
            //}

            //foreach (string s in this.ListStringSpecialFunctions)
            //{
            //    string buildstring1 = s.Substring(0, s.IndexOf(" "));
            //    string buildstring2 = s.Substring(s.IndexOf(" "));

            //    string built = buildstring1 + buildstring2;

            //    ModernWpf.MessageBox.Show(built);

            //    if (!specialList.Contains(built))
            //    {
            //        //ModernWpf.MessageBox.Show(s);

            //        specialList.Add(built);
            //    }
            //}

            // Label list
            List<string> labelList = new List<string>();

            // For loop to go through ToolTip dictionary
            foreach (KeyValuePair<string, string> entry in this.ToolTipDict)
            {
                // string key
                string k = entry.Key.ToString();

                // if key found in special list then add to label list. Just add speciallist to label list.
                if (specialList.Contains(k))
                {
                    if (!labelList.Contains(k))
                    {
                        labelList.Add(k);
                    }
                }
                // If key has a space " " then get first word part before space and add to label list
                else if (k.IndexOf(" ") != -1)
                {
                    k = k.Substring(0, k.IndexOf(" "));

                    if (!labelList.Contains(k))
                    {
                        labelList.Add(k);
                    }
                }
                // Add key to label list otherwise for things without spaces
                else
                {
                    if (!labelList.Contains(k))
                    {
                        labelList.Add(k);
                    }
                }
            }

            //if (labelList.Contains("Install-WSL"))
            //{
            //   // ModernWpf.MessageBox.Show("true");
            //}

            //List<string> keyList = new List<string>(this.ToolTipDict.Keys);

            //foreach (string s in labelList)
            //{
            //    if (s.Contains("UWP"))
            //    {
            //        ModernWpf.MessageBox.Show(s);
            //    }
            //}

            // string o
            string o = "";

            // single tooltipList contains labels that you want to have only one value for tooltip. The entries are needed like Control Panel for PinToStart
            List<string> singleToolTipList = new List<string>();// { "OneDrive -AllUsers" };// "UninstallUWPApps", "PinToStart -Tiles" }; 
                                                                //dontList = dontList.Concat(this.ListStringSpecialFunctions).ToList();

            /// List of all functionnames that need own tooltip // mozilla double double microsoft waste global
            //List<string> allFunctionNamesThatNeedOwnToolTip = MainWindow.listStringAllFunctionNamesThatNeedOwnToolTip;
            List<string> allFunctionNamesThatNeedOwnToolTip = this.ListStringFunctionNamesThatNeedOwnToolTip;

            singleToolTipList = singleToolTipList.Concat(allFunctionNamesThatNeedOwnToolTip).ToList();

            // Repeat list 2 bullets label
            List<string> repeatTwoToolTipList = new List<string>();

            // Normal functions // Mozilla Testing
            //List<string> allFunctionNamesWithoutTag = MainWindow.listStringAllFunctionNamesOnly;
            List<string> allFunctionNamesWithoutTag = this.ListStringFunctionNamesOnly;

            // Functions without any space at all
            List<string> allFunctionNamesWithoutTagWithoutTag = new List<string>();

            string stringSpace = " ";


            foreach (string s in allFunctionNamesWithoutTag)
            {
                if (!s.Contains(stringSpace))
                {
                    // Normal doesn't contain space
                    allFunctionNamesWithoutTagWithoutTag.Add(s);
                }
                else
                {
                    // Remove space if have space
                    allFunctionNamesWithoutTagWithoutTag.Add(s.Substring(0, s.IndexOf(stringSpace)));
                }
            }

            //var result2 = String.Join(",\n", allFunctionNamesWithoutTag.ToArray());
            //TestOutputWindow testOutputWindow = new TestOutputWindow(result2);
            //testOutputWindow.Show();

            // Count the functions now without space in a list
            var list = allFunctionNamesWithoutTagWithoutTag;
            var q = list.GroupBy(x => x)
                        .Select(g => new { Value = g.Key, Count = g.Count() })
                        .OrderByDescending(x => x.Count);

            // Convert to dictionary
            Dictionary<string, int> dictStringCount = new Dictionary<string, int>();
            foreach (var x in q)
            {
                //Console.WriteLine("Value: " + x.Value + " Count: " + x.Count);
                dictStringCount.Add(x.Value, x.Count);
            }

            //var list2 = dictStringCount.ToList();
            //var result2 = String.Join(",\n", list2.ToArray());
            //TestOutputWindow testOutputWindow = new TestOutputWindow(result2);
            //testOutputWindow.Show();

            // If the dictionary value has 2 counts or more add to repeat 2 list. Only 2 definitions
            foreach (var item in dictStringCount)
            {
                if ((item.Value > 1))// & (!allFunctionNamesThatNeedOwnToolTip.Contains(item.Key.ToString())))
                {
                    repeatTwoToolTipList.Add(item.Key.ToString());
                }
            }

            // Make a second list of repeat 2 list to remove function that have 'separate' attribute
            List<string> repeatTwoToolTipList2 = new List<string>();

            foreach (string s in repeatTwoToolTipList)
            {
                if (!singleToolTipList.Contains(s))
                {
                    repeatTwoToolTipList2.Add(s);
                }
            }

            // Testing

            //List<string> lsttd = new List<string>();

            //foreach (var item in this.ToolTipDict)
            //{                               
            //    if (item.Key.Contains(" -"))
            //    {
            //        string s1 = item.Key.Substring(0,item.Key.IndexOf(" "));
            //        string s2 = item.Key.Substring(item.Key.IndexOf("-")+1);
            //        lsttd.Add(s1);
            //        lsttd.Add(s2);
            //    }
            //    else
            //    {
            //        lsttd.Add(item.Key);
            //    }                   
            //}

            ////var list2 = dictStringCount.ToList();
            ////var result2 = String.Join(",\n", lsttd.ToArray());
            ////TestOutputWindow testOutputWindow = new TestOutputWindow(result2);
            ////testOutputWindow.Show();


            //q = lsttd.GroupBy(x => x)
            //            .Select(g => new { Value = g.Key, Count = g.Count() })
            //            .OrderByDescending(x => x.Count);

            //// Convert to dictionary
            //dictStringCount = new Dictionary<string, int>();
            //foreach (var x in q)
            //{
            //    //Console.WriteLine("Value: " + x.Value + " Count: " + x.Count);
            //    dictStringCount.Add(x.Value, x.Count);
            //}



            //// If the dictionary value has 2 counts or more add to repeat 2 list. Only 2 definitions
            //foreach (var item in dictStringCount)
            //{
            //    if ((item.Value == 3))// & (!allFunctionNamesThatNeedOwnToolTip.Contains(item.Key.ToString())))
            //    {
            //        repeatTwoToolTipList2.Add(item.Key.ToString());
            //    }
            //}

            // End test

            // Remove repeats in function name and tags for tooltips

            List<string> listStringFunctionOnly = new List<string>();
            List<string> listStringTagOnly = new List<string>();

            foreach (var item in this.ToolTipDict)
            {
                if (item.Key.Contains(" -"))
                {
                    string s1 = item.Key.Substring(0, item.Key.IndexOf(" "));

                    listStringFunctionOnly.Add(s1);

                }
                else
                {
                    listStringFunctionOnly.Add(item.Key);
                }
            }

            foreach (var item in this.ToolTipDict)
            {
                if (item.Key.Contains(" -"))
                {
                    string s2 = item.Key.Substring(item.Key.IndexOf("-") + 1);

                    listStringTagOnly.Add(s2);
                }
            }
            // Add end tags without the space and dash to repeat2
            foreach (string s in listStringTagOnly)
            {
                // if function name only also contains tag part
                if (listStringFunctionOnly.Contains(s))
                {
                    repeatTwoToolTipList2.Add(s);
                }
            }

            //var result2 = String.Join(",\n", repeatTwoToolTipList2.ToArray());
            //TestOutputWindow testOutputWindow = new TestOutputWindow(result2);
            //testOutputWindow.Show();

            //singleToolTipList.Add("Install-WSL");

            // For loop in label list to create labeltooltipdict
            foreach (string s in labelList)
            {
                // Just label and one definition functions
                if (singleToolTipList.Contains(s))
                {
                    // If the dictionary does not contain s then add it
                    if (!this.LabelToolTipDict.ContainsKey(s))
                    {
                        // Just label and bullet and one value of dictionary                        
                        this.LabelToolTipDict.Add(s, "\u2022 " + this.ToolTipDict[s]);
                    }
                    // Clear o just in case
                    o = "";
                }
                // More than one defintion
                else
                {
                    // Select Many is a list of all values containing key
                    var d = this.ToolTipDict.Where(KeyValuePair => KeyValuePair.Key.Contains(s)).SelectMany(KeyValuePair => "\u2022 " + KeyValuePair.Value + "\n\n").ToList();

                    ////var result2 = String.Join(",\n", d.ToArray());
                    //if (s == "ThisPC")
                    //{
                    //    TestOutputWindow testOutputWindow = new TestOutputWindow(s);
                    //    testOutputWindow.Show();
                    //}

                    // Cut down definition to two. Just find 's' in 'repeatList' list                     
                    if (repeatTwoToolTipList2.Contains(s))
                    {
                        foreach (char dl in d)
                        {
                            o += dl.ToString();
                        }

                        // Find 3rd case of bullet
                        int offset = o.IndexOf("\u2022 ");
                        offset = o.IndexOf("\u2022 ", offset + 1);
                        int result = o.IndexOf("\u2022 ", offset + 1);

                        // Check if there is a 3rd bullet
                        if (result != -1)
                        {
                            // Just get the 3 tooltips                        
                            o = o.Substring(0, result);
                        }
                        else
                        {
                            // Nothing
                            // o is just 2 bullets
                        }
                    }
                    // Rest
                    else
                    {
                        // Have to copy each char
                        foreach (char dl in d)
                        {
                            o += dl.ToString();
                        }
                    }

                    // Remove new line at end
                    if (o.EndsWith("\n"))
                    {
                        o = o.Substring(0, o.Length - 2);
                    }

                    // Make dictionary for label list
                    if (!this.LabelToolTipDict.ContainsKey(s))
                    {
                        this.LabelToolTipDict.Add(s, o);
                    }
                    // Clear o variable
                    o = "";
                }
            }

            //this.LabelToolTipDict["Install-WSL"] = "Hello";
            //if (this.LabelToolTipDict.ContainsKey("Install-WSL"))
            //{
            //    ModernWpf.MessageBox.Show(this.LabelToolTipDict["Install-WSL"]);
            //}

        }
    }
}