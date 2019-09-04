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
    public partial class Power_Manager : Form
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
            lbBatteryPercent.Text = String.Format("{0}%", SystemInformation.PowerStatus.BatteryLifePercent * 100);
            
            //set the color of the percent label based on the battery percentage
            if (SystemInformation.PowerStatus.BatteryLifePercent * 100 < 30 && SystemInformation.PowerStatus.PowerLineStatus != PowerLineStatus.Online)
            {
                //if the battery percent is less than 30 and the system is not plugged in
                lbBatteryPercent.ForeColor = Color.Red;
            }
            else
            {
                lbBatteryPercent.ForeColor = Color.DarkGreen;
            }
        }

        private void cbEditSettings_CheckedChanged(object sender, EventArgs e)
        {
            settingsPanel.Enabled = cbEditSettings.Checked;
        }
    }
}
