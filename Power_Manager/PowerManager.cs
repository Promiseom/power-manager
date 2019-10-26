using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Power_Manager
{
    public partial class Power_Manager : Form, ITaskManager
    {
        public Power_Manager()
        {
            InitializeComponent();          
        }

        private void Power_Manager_Load(object sender, EventArgs e)
        {
            batteryStatusMonitor.WorkerReportsProgress = true;
            batteryStatusMonitor.WorkerSupportsCancellation = false;
            batteryStatusMonitor.RunWorkerAsync();

            cbShutdownAction.SelectedIndex = 0;
            cbAutoShutdownAction.Items.AddRange(ShutdownManager.GetShutdownActions());
            cbAutoShutdownAction.SelectedIndex = 0;
        }

        private void batteryStatusMonitor_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                batteryStatusMonitor.ReportProgress(0);   //progress is not reported with numeric value
                Thread.Sleep(1000);
            }
        }

        private void batteryStatusMonitor_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {            
            lbBatteryStatus.Text = SystemInformation.PowerStatus.BatteryChargeStatus.ToString();
            
            if (lbBatteryStatus.Text != BatteryChargeStatus.NoSystemBattery.ToString())
            {
                lbBatteryPercent.Text = String.Format("{0}%", SystemInformation.PowerStatus.BatteryLifePercent * 100);
            }
            else
            {
                lbBatteryPercent.Text = "N/A";
            }

            if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Online)
            {
                lbPowerLineStatus.Text = "Online";
                lbPowerLineStatus.ForeColor = Color.DarkGreen;
            }
            else
            {
                lbPowerLineStatus.Text = "Offline";
                lbPowerLineStatus.ForeColor = Color.Red;
            }

            //set the color of the percent label based on the battery percentage
            if (SystemInformation.PowerStatus.BatteryLifePercent * 100 < 30 && SystemInformation.PowerStatus.PowerLineStatus != PowerLineStatus.Online)
            {      
                //if the battery percent is less than 30 and the system is not plugged in
                lbBatteryPercent.ForeColor = Color.Red;
            }
            else
            {
                //make sure there's battery installed for the text color to be green
                lbBatteryPercent.ForeColor = (SystemInformation.PowerStatus.BatteryChargeStatus == BatteryChargeStatus.NoSystemBattery) ? Color.Red : Color.DarkGreen;
            }                        
        }

        private void cbEditSettings_CheckedChanged(object sender, EventArgs e)
        {
            settingsPanel.Enabled = cbEditSettings.Checked;
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            shutdownPassword.UseSystemPasswordChar = !((CheckBox)sender).Checked;
        }

        private void btnAutoShutdown_Click(object sender, EventArgs e)
        {
            //get task properties from controls
            int action = cbAutoShutdownAction.SelectedIndex;
            int time = (int)autoShutdownTime.Value;
            string password = shutdownPassword.Text;
            string message = shutdownMessage.Text;

            //display the countdown window
            AutoShutdownTask task = new AutoShutdownTask((ShutdownManager.SHUTDOWNACTION)action, time);
            task.ChangeShutdownPassword(password);
            task.ShutdownMessage = message;
            task.SetITaskListener(this);
            task.Start();
        }

        public void OnTaskCompleted(IShutdownTask task)
        {
            btnAutoShutdown.Enabled = true;
            btnShutdown.Enabled = true;
            //MessageBox.Show("Shutdown task has completed");
        }

        public void OnTaskAborted(IShutdownTask task)
        {
            MessageBox.Show("Shutdown Task has been aborted");
        }

        public void OnTaskStarted(IShutdownTask task)
        {
            btnShutdown.Enabled = false;
            btnAutoShutdown.Enabled = false;
            //MessageBox.Show("Shutdown Task has been started");
        }

        private void Power_Manager_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
