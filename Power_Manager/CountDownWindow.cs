using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Manager
{
    public partial class CountDownWindow : Form
    {
        //used to communicate with the tasking managing this window
        IShutdownTask task;

        private CountDownWindow()
        {
            InitializeComponent();
        }

        public CountDownWindow(IShutdownTask listener):this()
        {
            task = listener;
        }

        public void SetTimer(int newTime)
        {
            int hours = newTime / 3600;
            newTime = newTime % 3600;
            int minutes = newTime / 60;
            newTime = newTime % 60;
            
            cd_timer.Text = String.Format("{0:00}:{1:00}:{2:00}", hours, minutes, newTime);
        }

        public void SetMessage(string message)
        {
            shutdownMessage.Text = message;
        }

        private void CountDownWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!task.IsTaskRunning())
            {
                return;
            }

            DialogResult rs = MessageBox.Show(this, "Abort shutdown task?", "Abort Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (task.IsTaskProtected())
                {
                    MessageBox.Show(this, "This task is protected", "Note", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    do
                    {
                        //display window for user to input password                       
                        string userEntr = PasswordInputDialog.ShowInputDialog(this, "Enter your password");
                        if (task.Abort(userEntr))
                        {                            
                            return;
                        }
                    }while(MessageBox.Show(this, "Invalid Password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry);
                }
                try
                {
                    task.Abort();
                }
                catch (AbortFailedException arg)
                {
                    MessageBox.Show(this, "Failed to abort task, task is protected", "Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnAbortShutdown_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
