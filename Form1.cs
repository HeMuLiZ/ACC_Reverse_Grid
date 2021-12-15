using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace ACC_Reverse_Grid_App
{
    public partial class Form1 : Form
    {
        public string path { get; set; }
        private List<Tuple<string, string>> drivers { get; set; }

        FileReader fileread = new FileReader();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int practiceMin = Convert.ToInt32(Math.Round(sessionMinSelector.Value, 0));
            Settings.Instance.PracticeMinutes = practiceMin;

            int lowDNF = Convert.ToInt32(Math.Round(numericLowDNF.Value, 0));
            Settings.Instance.LowDNF = lowDNF;

            int highDNF = Convert.ToInt32(Math.Round(numericHighDNF.Value, 0));
            Settings.Instance.HighDNF = highDNF;

            ToolTip toolTip1 = new ToolTip();
            ToolTip toolTip2 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip2.ShowAlways = true;
            toolTip1.SetToolTip(lblLowDNF, "The ACC does not always know if someone was a DNF. This setting sets the driver to DNF if the totaltime is less than the winner's totaltime - this value. Not change anything in results file.");
            toolTip2.SetToolTip(lblDNFHigh, "The ACC does not always know if someone was a DNF. This setting sets the driver to DNF if the totaltime is more than the winner's totaltime + this value. Not change anything in results file.");

            string serverPath = Directory.GetCurrentDirectory() + "/settings.txt";
            if (File.Exists(serverPath))
            {
                btnResultsFile.Enabled = true;
            }
                info();
        }

        public void info()
        {
            string serverPath = Directory.GetCurrentDirectory() + "/settings.txt";
            if (File.Exists(serverPath))
            {
                string settings = System.IO.File.ReadAllText(Directory.GetCurrentDirectory() + "/settings.txt");
                var serverName = System.IO.Path.GetFileName(settings);
                lblServer.Text = "Current Server: " + serverName;
            }
            else
            {
                lblServer.Text = "Server file needed";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                btnReverse.Enabled = false;
                btnQual.Enabled = false;
                btnResultsFile.Enabled = false;
                btnServerFile.Enabled = false;
                fileread.watcherSwitch = true;
                fileread.Filewatcher();
            }

            else
            {
                fileread.watcherSwitch = false;
                btnReverse.Enabled = true;
                btnQual.Enabled = true;
                btnResultsFile.Enabled = true;
                btnServerFile.Enabled = true;
            }
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            btnQual.Enabled = true;
            GridOrder reverseGrid = new GridOrder();
            reverseGrid.GetDriversFromLastRace(path);
            lblStatus.Text = "Grid reversed. Qualify session removed.";
        }

        private void btnServerFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 0;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                File.WriteAllText("settings.txt", selectedFileName);
                btnResultsFile.Enabled = true;
            }
            info();
        }

        private void btnResultsFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();

            openFileDialog2.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog2.Filter = "All files (*.*)|*.*";
            openFileDialog2.FilterIndex = 0;
            openFileDialog2.RestoreDirectory = true;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog2.FileName;
                var resultsFileName = System.IO.Path.GetFileName(path);
                lblResultsFile.Text = "Results file: " + resultsFileName;
                btnReverse.Enabled = true;

                var results = fileread.Readfile(path);
                SetDriversInListBox(path);
            }
            setGridBtn.Enabled = true;
            UpButton.Enabled = true;
            DownButton.Enabled = true;
        }

        private void btnQual_Click(object sender, EventArgs e)
        {
            Qualifying quali = new Qualifying();
            quali.RemoveDefauldGridPositions();
            lblStatus.Text = "Qualifying added.";
        }

        private void sessionMinSelector_ValueChanged(object sender, EventArgs e)
        {
            int practiceMin = Convert.ToInt32(Math.Round(sessionMinSelector.Value, 0));
            Settings.Instance.PracticeMinutes = practiceMin;
        }

        private void DNFsBackChkbox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Instance.DNFsBackOfGrid = DNFsBackChkbox.Checked;
        }

        public void SetDriversInListBox(string path)
        {
            GridOrder rev = new GridOrder();
            drivers = rev.DriversToListFromResults(path);
            
            for (int i = 0; i < drivers.Count(); i++)
            {
                driverlist.Items.Add(drivers[i].Item2);
            }
        }

        private void serverBtn_Click(object sender, EventArgs e)
        {
            Server server = new Server();
            server.RestartServer();
            lblStatus.Text = "Server restarted.";
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            if (driverlist.SelectedItem != null)
            {
                int pos = driverlist.Items.IndexOf(driverlist.SelectedItem);
                if (pos > 0)
                {
                    driverlist.Items.Insert(pos - 1, driverlist.SelectedItem);
                    driverlist.Items.RemoveAt(pos + 1);
                    driverlist.SelectedItem = driverlist.Items[pos - 1];
                }
            }
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            if (driverlist.SelectedItem != null)
            {
                int pos = driverlist.Items.IndexOf(driverlist.SelectedItem);
                if (pos != driverlist.Items.Count - 1)
                {
                    driverlist.Items.Insert(pos + 2, driverlist.SelectedItem);
                    driverlist.Items.RemoveAt(pos);
                    driverlist.SelectedItem = driverlist.Items[pos + 1];
                }
            }
        }

        private void setGridBtn_Click(object sender, EventArgs e)
        {
            var newOrder = new List<Tuple<string, string>>();

            foreach (var item in driverlist.Items)
            {
                for (int i = 0; i < driverlist.Items.Count; i++)
                {
                    if (drivers[i].Item2 == item.ToString())
                    {
                        newOrder.Add(drivers[i]);
                    }
                }
            }

            var entrylist = new Entrylist();
            entrylist.SetGrid(newOrder);
            lblStatus.Text = "Modified order added.";
        }

        private void UseDNFSettingsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Instance.UseDnfSettings = UseDNFSettingsCheckBox.Checked;
        }

        private void numericLowDNF_ValueChanged(object sender, EventArgs e)
        {
            int lowDNF = Convert.ToInt32(Math.Round(numericLowDNF.Value, 0));
            Settings.Instance.LowDNF = lowDNF;
        }

        private void numericHighDNF_ValueChanged(object sender, EventArgs e)
        {
            int highDNF = Convert.ToInt32(Math.Round(numericHighDNF.Value, 0));
            Settings.Instance.HighDNF = highDNF;
        }
    }
}
