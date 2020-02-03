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
    public partial class AutoShutdownManager : Form, ITaskManager
    {
        private PowerLineStatus prevPowerLineStatus;
        private bool pNotif = false;
        //indicates the hide window option has been confirmed
        private bool isHideConfirmed;
        //this must be set if the window is hidden
        private int invisibilityTimeout;

        public AutoShutdownManager()
        {
            InitializeComponent(); 
        }

        private void Power_Manager_Load(object sender, EventArgs e)
        {
            isHideConfirmed = false;
            
            //setup the battery status background monitor
            batteryStatusMonitor.WorkerReportsProgress = true;
            batteryStatusMonitor.WorkerSupportsCancellation = false;
            batteryStatusMonitor.RunWorkerAsync();
                        
            cbShutdownAction.Items.AddRange(ShutdownManager.GetShutdownActions(SHUTDOWN_TYPE.SHUTDOWN_POWER_LOSS));
            cbAutoShutdownAction.Items.AddRange(ShutdownManager.GetShutdownActions(SHUTDOWN_TYPE.SHUTDOWN_NORMAL));
            cbShutdownAction.SelectedIndex = 0;
            cbAutoShutdownAction.SelectedIndex = 0;
                                    
            prevPowerLineStatus = SystemInformation.PowerStatus.PowerLineStatus;
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
            CheckPowerLineStatus();
            UpdateBatteryStats();
        }

        private void CheckPowerLineStatus()
        {
            //checks if power has been lost or restored
            PowerLineStatus currPowerLineStatus= SystemInformation.PowerStatus.PowerLineStatus;
            if (prevPowerLineStatus == PowerLineStatus.Online)
            {
                if (currPowerLineStatus == PowerLineStatus.Offline || currPowerLineStatus == PowerLineStatus.Unknown)
                {
                    if (!pNotif)
                    {
                        pNotif = true;
                        switch(cbShutdownAction.SelectedIndex)
                        {
                            case 0:
                                int action = SelectionInputDialog.ShowSelectionInputDialog(this, "Choose Shutdown Action", ShutdownManager.GetShutdownActions(SHUTDOWN_TYPE.SHUTDOWN_POWER_LOSS));
                                //make sure we have a valid shutdown action
                                if (action >= 0)
                                {
                                    ShutdownManager.Shutdown((SHUTDOWN_ACTION_POWER_LOSS)action);
                                }
                             break;
                            default:
                                SHUTDOWN_ACTION_POWER_LOSS sdAction = (SHUTDOWN_ACTION_POWER_LOSS)cbShutdownAction.SelectedIndex;
                                ShutdownManager.Shutdown(sdAction); 
                                //MessageBox.Show(this, "Computer Shutdown Mode: " + sdAction.ToString(), "Warning");
                                break;
                        }
                        //notifications come as dialogs which will block the 
                        //execution of the statements after it
                        //execution continues when the dialog is closed,
                        //when this happens, notification is closed
                        pNotif = false;
                    }
                }
            }
            else
            {
                if (currPowerLineStatus == PowerLineStatus.Online)
                {
                    if(pNotif)
                    {
                        SelectionInputDialog.CloseDialog();
                        pNotif = false;
                    }
                }
            }
            prevPowerLineStatus = currPowerLineStatus;
        }

        private void UpdateBatteryStats()
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
            //not cancellable if checked
            bool isCancellable = !cbLockTask.Checked;
            bool isNinjaMode = cbNinjaMode.Checked;

            //display the countdown window
            AutoShutdownTask task = (password.Length <= 0)? new AutoShutdownTask((SHUTDOWNACTION)action, time, message, isCancellable) : new AutoShutdownTask((SHUTDOWNACTION)action, time, password, message);
            //task.ChangeShutdownPassword(password);
            //task.ShutdownMessage = message;
            task.SetITaskListener(this);
            if (isNinjaMode)
            {
                //time out is -1 so it never be visible before shutdown
                task.SetCountdownVisibility(false, -1);
            }
            else
            {
                task.SetCountdownVisibility(!cbHideCountdown.Checked, invisibilityTimeout);
            }
            this.Visible = false;
            task.Start();
        }

        public void OnTaskCompleted(IShutdownTask task)
        {
            btnAutoShutdown.Enabled = true;
            btnShutdown.Enabled = true;            
            //MessageBox.Show("Shutdown task has completed");
            this.Visible = true;
        }

        public void OnTaskAborted(IShutdownTask task)
        {
            btnAutoShutdown.Enabled = true;
            btnShutdown.Enabled = true;
            MessageBox.Show("Shutdown Task has been aborted", "Information", MessageBoxButtons.OK);
            this.Visible = true;
        }

        public void OnTaskStarted(IShutdownTask task)
        {
            btnShutdown.Enabled = false;
            btnAutoShutdown.Enabled = false;
            //MessageBox.Show("Shutdown Task has been started");
        }

        public void OnTaskValueChanged(TASKVALUES val, dynamic newValue)
        {
            switch (val)
            {
                case TASKVALUES.TIME_REMAINING:
                    break;
                case TASKVALUES.WINDOW_VISIBILITY:
                    //make sure value is expected type
                    if (!(newValue is Boolean))
                    {
                        throw new ArgumentException("type of new value does not match expected type Boolean");
                    }
                    //set the new visibilty of the manager window
                    this.Visible = newValue;
                    break;
            }
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            SHUTDOWNACTION ac = (SHUTDOWNACTION)cbAutoShutdownAction.SelectedIndex;
            DialogResult rs = MessageBox.Show(this, "Computer will " + ac.ToString() +" immediately. Are you sure you want to continue?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(rs == DialogResult.Yes)
            {                
                ShutdownManager.Shutdown(ac);
            }
        }

        private void cbHideCountdown_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = ((CheckBox)sender).Checked;
            if (isChecked && !isHideConfirmed)
            {
                ((CheckBox)sender).Checked = false;
                try
                {
                    int time = NumericInputDialog.ShowInputDialog(this, "Choose Time", "What Time Do You Want The Countdown Window To Appear");
                    isHideConfirmed = true;
                    invisibilityTimeout = time;
                    ((CheckBox)sender).Checked = true;
                    MessageBox.Show(this, "Countdown window will reappear in " + time + " seconds.", "Notice!");
                }catch(DialogCancelResultException arg)
                {                    
                }
            }
            else
            {
                isHideConfirmed = false;
            }
        }

        /// <summary>
        /// show a tooltip when the user hovers over this control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbHideCountdown_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(cbHideCountdown, "Hides the shutdown manager until time set to reappear.");
        }

        private void AutoShutdownManager_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                //Hide();
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }
    }
}
