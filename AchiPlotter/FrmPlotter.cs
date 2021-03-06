using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SimpleChiaPlotter
{
    public partial class FrmPlotter : Form
    {
        private Achi achi = new Achi();
        IniFile MyIni = new IniFile("Achi_Plotter.ini");

        public FrmPlotter()
        {
            InitializeComponent();
            LoadConfig();
        }

        /// <summary>
        /// Load the settings from the ini file and fills textboxs and checkboxes or creates a new ini file if it does not exist.
        /// </summary>
        private void LoadConfig()
        {
            string curFile = "Achi_Plotter.ini";
            if (File.Exists(curFile))
            {
                // ini file exists so try to read from it and fill textboxes and checkboxes with saved data
                try
                {
                    MyIni = new IniFile("Achi_Plotter.ini");
                    textBoxPlotCount.Text = MyIni.Read("TotalPlots");
                    textBoxBuckets.Text = MyIni.Read("Buckets");
                    textBoxThreads.Text = MyIni.Read("Threads");
                    textBoxTempDir1.Text = MyIni.Read("TempDir1");
                    textBoxTempDir2.Text = MyIni.Read("TempDir2");
                    textBoxFinalDir.Text = MyIni.Read("TargetDir");
                    textBoxFarmerPublicKey.Text = MyIni.Read("FarmerPublicKey");
                    textBoxPoolPublicKey.Text = MyIni.Read("PoolPublicKey");
                    // if these keys dont exist it will crash trying to read them 
                    // so check first and create a default for them 
                    // needed for upgrading from old version of launcher and keeping old settings
                    // without doing these steps upgrades will need to have all the saved info entered again 
                    // (eg: directories and keys)
                    if (!MyIni.KeyExists("Buckets3")) { MyIni.Write("Buckets3", "256"); }
                    textBoxBuckets3.Text = MyIni.Read("Buckets3");
                    if (!MyIni.KeyExists("TempToggle")) { MyIni.Write("TempToggle", "False"); }
                    checkBoxSwap.Checked = bool.Parse(MyIni.Read("TempToggle"));
                    if (!MyIni.KeyExists("WaitForCopy")) { MyIni.Write("WaitForCopy", "False"); }
                    checkBoxWait.Checked = bool.Parse(MyIni.Read("WaitForCopy"));
                    if (!MyIni.KeyExists("TempDir2Enabled")) { MyIni.Write("TempDir2Enabled", "False"); }
                    checkBox2ndTempDir.Checked = bool.Parse(MyIni.Read("TempDir2Enabled")); 
                    if (!MyIni.KeyExists("EnableBuckets3")) { MyIni.Write("EnableBuckets3", "False"); }
                    checkBoxBuckets3.Checked = bool.Parse(MyIni.Read("EnableBuckets3"));
                    if (!MyIni.KeyExists("NFTAddress")) { MyIni.Write("NFTAddress", null); }
                    textBoxNFTAddress.Text = MyIni.Read("NFTAddress");
                    if (!MyIni.KeyExists("NFTEnabled")) { MyIni.Write("NFTEnabled", "False"); }
                    checkBoxNFTAddress.Checked = bool.Parse(MyIni.Read("NFTEnabled"));
                    if (!MyIni.KeyExists("PoolKeyEnabled")) { MyIni.Write("PoolKeyEnabled", "true"); }
                    checkBoxPublicPoolKey.Checked = bool.Parse(MyIni.Read("PoolKeyEnabled"));
                }
                catch (Exception)
                {
                    // error loading ini file so create a new one with defaults
                    CreateConfig();
                    MyIni = new IniFile("Achi_Plotter.ini");
                }
            }
            else
            {
                // ini file does not exist so create one with defaults
                CreateConfig();
            }
            var achi = new Achi
            {
                Directory = MyIni.Read("Directory"),
                Executable = MyIni.Read("Executable"),
                Buckets = MyIni.Read("Buckets"),
                Buckets3 = MyIni.Read("Buckets3"),
                Threads = MyIni.Read("Threads"),
                TotalPlots = MyIni.Read("TotalPlots"),
                FarmerPublicKey = MyIni.Read("FarmerPublicKey"),
                PoolPublicKey = MyIni.Read("PoolPublicKey"),
                TempDir1 = MyIni.Read("TempDir1"),
                TempDir2 = MyIni.Read("TempDir2"),
                TargetDir = MyIni.Read("TargetDir"),
                TempToggle = bool.Parse(MyIni.Read("TempToggle")),
                WaitForCopy = bool.Parse(MyIni.Read("WaitForCopy")),
                TempDir2Enabled = bool.Parse(MyIni.Read("TempDir2Enabled")),
                EnableBuckets3 = bool.Parse(MyIni.Read("EnableBuckets3")),
                NFTAddress = MyIni.Read("NFTAddress"),
                NFTEnabled = bool.Parse(MyIni.Read("NFTEnabled")),
                PoolKeyEnabled = bool.Parse(MyIni.Read("PoolKeyEnabled"))
            };
            if (achi.Directory == "")
            {
                // if madmax directory is null in ini file open the settings form
                MessageBox.Show("Please configure Achi_Plot Directory!", "Urgent!");
                FrmSettings f2 = new FrmSettings();
                f2.ShowDialog();
            }
        }

        /// <summary>
        /// Creates a ini file with default settings
        /// </summary>
        private void CreateConfig()
        {
            MyIni.Write("Directory", null);
            MyIni.Write("Executable", "achi_plot.exe");
            MyIni.Write("Buckets", "256");
            MyIni.Write("Buckets3", "256");
            MyIni.Write("Threads", "4");
            MyIni.Write("TotalPlots", "1");
            MyIni.Write("FarmerPublicKey", null);
            MyIni.Write("PoolPublicKey", null);
            MyIni.Write("TempDir1", null);
            MyIni.Write("TempDir2", null);
            MyIni.Write("TargetDir", null);
            MyIni.Write("TempToggle", "false");
            MyIni.Write("WaitForCopy", "false");
            MyIni.Write("TempDir2Enabled", "false");
            MyIni.Write("EnableBuckets3", "false");
            MyIni.Write("NFTAddress", null);
            MyIni.Write("NFTEnabled", "false");
            MyIni.Write("PoolKeyEnabled", "true");
            // set default behaviour for form
            checkBoxPublicPoolKey.Checked = true;
        }

        private Achi SaveConfig()
        {
            // get settings from checkboxes and textboxes
            var achi = new Achi
            {
                Directory = MyIni.Read("Directory"),
                Executable = MyIni.Read("Executable"),
                Threads = textBoxThreads.Text,
                Buckets = textBoxBuckets.Text,
                Buckets3 = textBoxBuckets3.Text,
                TotalPlots = textBoxPlotCount.Text,
                FarmerPublicKey = textBoxFarmerPublicKey.Text,
                PoolPublicKey = textBoxPoolPublicKey.Text,
                NFTAddress = textBoxNFTAddress.Text,
                TempDir1 = textBoxTempDir1.Text,
                TempDir2 = textBoxTempDir2.Text,
                TargetDir = textBoxFinalDir.Text,
                // setup bools in the achi class
                TempToggle = checkBoxSwap.CheckState == CheckState.Checked,
                WaitForCopy = checkBoxWait.CheckState == CheckState.Checked,
                TempDir2Enabled = checkBox2ndTempDir.CheckState == CheckState.Checked,
                EnableBuckets3 = checkBoxBuckets3.CheckState == CheckState.Checked,
                NFTEnabled = checkBoxNFTAddress.CheckState == CheckState.Checked,
                PoolKeyEnabled = checkBoxPublicPoolKey.CheckState == CheckState.Checked
            };
            // save settings to ini file
            MyIni.Write("Directory", achi.Directory);
            MyIni.Write("Executable", achi.Executable);
            MyIni.Write("Threads", achi.Threads);
            MyIni.Write("Buckets", achi.Buckets);
            MyIni.Write("Buckets3", achi.Buckets3);
            MyIni.Write("TotalPlots", achi.TotalPlots);
            MyIni.Write("FarmerPublicKey", achi.FarmerPublicKey);
            MyIni.Write("PoolPublicKey", achi.PoolPublicKey);
            MyIni.Write("TempDir1", achi.TempDir1);
            MyIni.Write("TempDir2", achi.TempDir2);
            MyIni.Write("TargetDir", achi.TargetDir);
            MyIni.Write("NFTAddress", achi.NFTAddress);
            // save bools to the ini file
            MyIni.Write("TempToggle", achi.TempToggle.ToString());
            MyIni.Write("WaitForCopy", achi.WaitForCopy.ToString());
            MyIni.Write("TempDir2Enabled", achi.TempDir2Enabled.ToString());
            MyIni.Write("EnableBuckets3", achi.EnableBuckets3.ToString());
            MyIni.Write("NFTEnabled", achi.NFTEnabled.ToString());
            MyIni.Write("PoolKeyEnabled", achi.PoolKeyEnabled.ToString());

            return achi;
        }
        /// <summary>
        /// Form Menu
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // exit program
            Application.Exit();
        }
        /// <summary>
        /// Form Menu
        /// </summary>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open about form
            FrmAbout frmAbout = new FrmAbout();
            frmAbout.ShowDialog();
        }
        /// <summary>
        /// Form Menu
        /// </summary>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open settings form
            FrmSettings frmSettings = new FrmSettings();
            frmSettings.ShowDialog();
        }
        /// <summary>
        /// Setup variables and run plotter class from here after clicking the 'Build Plots' button
        /// </summary>
        private void btnPlot_Click(object sender, EventArgs e)
        {
            // get achi class from current settings (textboxes and checkboxes)
            var achi = SaveConfig();
            if (textBoxTempDir1.Text == "" || textBoxFinalDir.Text == "" || (checkBox2ndTempDir.Checked == true && textBoxTempDir2.Text == ""))
            {
                    MessageBox.Show("Please configure plotting directories!", "Urgent!");
            }
            else
            {
                var plotter = new Plotter();
                var tempDir2 = false;
                var wait = false;
                var tempToggle = false;
                var NFTAddress = false;
                // check is using 2 temp dirs
                if (checkBox2ndTempDir.Checked) 
                { 
                    tempDir2 = true; 
                    // only bother with checking for swap command if we are using 2 temp directories
                    if (checkBoxSwap.Checked)
                    {
                        tempToggle = true;
                    }
                }
                // check for wait for plot copy
                if (checkBoxWait.Checked) { wait = true; }
                // check for NFT address
                if (checkBoxNFTAddress.Checked) { NFTAddress = true; }
                plotter.Run(achi, tempDir2, wait, tempToggle, NFTAddress);
            }

        }
        /// <summary>
        /// open dialog box for temp dir 1 and then save settings
        /// </summary>
        private void btnTempDir1_Click(object sender, EventArgs e)
        {
            // save current settings
            SaveConfig();
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    achi.TempDir1 = fbd.SelectedPath + "\\";
                    textBoxTempDir1.Text = fbd.SelectedPath + "\\";
                    // save tempdir1 setting
                    MyIni.Write("TempDir1", achi.TempDir1);
                    LoadConfig();
                }
            }
        }

        /// <summary>
        /// open dialog box for temp dir 2 and then save settings
        /// </summary>
        private void btnTempDir2_Click(object sender, EventArgs e)
        {
            // save current settings
            SaveConfig();
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    achi.TempDir2 = fbd.SelectedPath + "\\";
                    textBoxTempDir2.Text = fbd.SelectedPath + "\\";
                    // save tempdir2 setting
                    MyIni.Write("TempDir2", achi.TempDir2);
                    LoadConfig();
                }
            }
        }

        /// <summary>
        /// open dialog box for final dir and then save settings
        /// </summary>
        private void btnFinalDir_Click(object sender, EventArgs e)
        {
            // save current settings
            SaveConfig();
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    achi.TargetDir = fbd.SelectedPath + "\\";
                    textBoxFinalDir.Text = fbd.SelectedPath + "\\";
                    // save final dir setting
                    MyIni.Write("TargetDir", achi.TargetDir);
                    LoadConfig();
                }
            }
        }

        /// <summary>
        /// simple launcher to open website link
        /// </summary>
        private void BuyMeACoffee()
        {
            System.Diagnostics.Process.Start("https://discord.com/invite/wSr84p28eN");
        }
        /// <summary>
        /// button action for link
        /// </summary>
        private void btnBuyMeACoffee_Click(object sender, EventArgs e)
        {
            BuyMeACoffee();
        }

        /// <summary>
        /// button action for link
        /// </summary>
        private void lblPlotterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PlotterLink();
        }
        /// <summary>
        /// simple launcher to open website link
        /// </summary>
        private void PlotterLink()
        {
            System.Diagnostics.Process.Start("https://download.achicoin.org/achi_plot_beta.zip");
        }

        private void checkBoxPublicPoolKey_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPublicPoolKey.CheckState == CheckState.Checked)
            {
                textBoxPoolPublicKey.Enabled = true;
                textBoxNFTAddress.Enabled = false;
                checkBoxNFTAddress.Checked = false;
            }
            else
            {
                checkBoxPublicPoolKey.Checked = false;
                checkBoxNFTAddress.Checked = true;
                textBoxPoolPublicKey.Enabled = false;
                textBoxNFTAddress.Enabled = true;
            }
        }

        private void checkBoxNFTAddress_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNFTAddress.CheckState == CheckState.Checked)
            {
                textBoxPoolPublicKey.Enabled = false;
                textBoxNFTAddress.Enabled = true;
                checkBoxPublicPoolKey.Checked = false;
            }
            else
            {
                checkBoxPublicPoolKey.Checked = true;
                checkBoxNFTAddress.Checked = false;
                textBoxPoolPublicKey.Enabled = true;
                textBoxNFTAddress.Enabled = false;
            }
        }
    }
}
