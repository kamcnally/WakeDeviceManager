using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace WakeManager
{
    public partial class WakeMenu : Form
    {
        private List<string> enabledDevices;
        private bool disableAll = false;

        public WakeMenu()
        {
            InitializeComponent();
            
            this.enabledDevices = new List<string>();
            this.getWakeEnabledDeviceList();
            if (this.enabledDevices.Count >= 7)
            {
                this.enabledDevices.RemoveRange(this.enabledDevices.Count - 3, 3);
                this.enabledDevices.RemoveRange(0, 4);
            }

            foreach (string device in enabledDevices)
                this.listDevices.Items.Add(device);

            if (this.enabledDevices == null)
            {
                this.listDevices.Items.Add("Error getting devices");
                this.listDevices.Enabled = false;
                this.buttonDisable.Enabled = false;
                this.buttonSelectAll.Enabled = false;
            }

            if (this.enabledDevices.Count != 0)
                return;
            
            this.listDevices.Items.Add("No devices");
            this.listDevices.Enabled = false;
            this.buttonDisable.Enabled = false;
            this.buttonSelectAll.Enabled = false;
        }

        private void getWakeEnabledDeviceList()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = "C:\\Windows\\System32\\cmd.exe";
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.RedirectStandardError = true;
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;
            Process process = new Process();
            process.StartInfo = processStartInfo;
            // ISSUE: method pointer
            process.OutputDataReceived += new DataReceivedEventHandler(cmd_DataReceived);
            process.EnableRaisingEvents = true;
            process.Start();
            process.BeginOutputReadLine();
            process.StandardInput.WriteLine("C:\\Windows\\System32\\powercfg.exe -devicequery wake_armed");
            process.StandardInput.WriteLine("exit");
            process.StandardInput.Close();
            process.WaitForExit();
            process.Close();
        }

        private void disableDevicesFromList()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo();
            processStartInfo.FileName = "C:\\Windows\\System32\\cmd.exe";
            processStartInfo.RedirectStandardInput = true;
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;
            processStartInfo.CreateNoWindow = true;
            Process process = new Process();
            process.StartInfo = processStartInfo;
            process.EnableRaisingEvents = true;
            process.Start();
            foreach (string str in this.enabledDevices)
                process.StandardInput.WriteLine("C:\\Windows\\System32\\powercfg.exe -devicedisablewake \"" + str + "\"");
            process.StandardInput.WriteLine("exit");
            process.StandardInput.Close();
            process.WaitForExit();
            process.Close();
        }

        private void cmd_DataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data == null)
                return;
            this.enabledDevices.Add(e.Data);
        }

        private void buttonDisable_Click(object sender, EventArgs e)
        {
            this.enabledDevices.Clear();
            foreach (string str in this.listDevices.SelectedItems)
                this.enabledDevices.Add(str);
            this.disableDevicesFromList();
            this.Close();
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (this.listDevices.SelectedItems.Count == this.listDevices.Items.Count)
                flag = false;

            for (int index = 0; index < this.listDevices.Items.Count; ++index)
                this.listDevices.SetSelected(index, flag);
        }

        private void WakeMenu_Load(object sender, EventArgs e)
        {
            if (!this.disableAll)
                return;
            this.disableDevicesFromList();
            this.Close();
        }
    }
}
