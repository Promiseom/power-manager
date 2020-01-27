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
    /// <summary>
    /// Count down window displays the timer to the user as it counts down.
    /// The window contains an abort button which can be used to cancel the shutdown and
    /// optional shutdown message to be displayed to the user.
    /// 
    /// Shutdown message usually contains a reason for the shutdown.
    /// </summary>
    public partial class CountDownWindow : Form
    {
        //used to communicate with the tasking managing this window
        IShutdownTask task;

        private CountDownWindow()
        {
            InitializeComponent();

            //start with minimum size (height)
            Height = MinimumSize.Height;

            SetWindowLocation();
        }

        private void SetWindowLocation()
        {
            //use size of screen to position window at the bottom right
            //corner of the window screen.
            Rectangle size = Screen.PrimaryScreen.WorkingArea;
            int xPos = size.Width - Width;
            int yPos = size.Height - Height;

            Location = new Point(xPos + 10, yPos + 10);
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

            bool isAborted = false;
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
                        isAborted = task.Abort(userEntr);
                    } while (MessageBox.Show(this, "Invalid Password", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry);
                }
                else
                {
                    try
                    {
                        isAborted = task.Abort();
                    }
                    catch (AbortFailedException arg)
                    {
                        MessageBox.Show(this, "Failed to abort task, task is protected", "Note", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            //countdown window only closes if the task was aborted.
            e.Cancel = !isAborted;
        }

        private void btnAbortShutdown_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMore_Resize(object sender, EventArgs e)
        {
            SetWindowLocation();
        }
                
        private void btnMore_Click(object sender, EventArgs e)
        {
            if (Height < MaximumSize.Height)
            {
                //increase the size of the window to reveal the message
                Height = MaximumSize.Height;
            }
            else
            {
                //decrease the size of the window to conceal the message
                Height = MinimumSize.Height;
            }            
        }

        private void CountDownWindow_Resize(object sender, EventArgs e)
        {
            SetWindowLocation();
        }
    }
}
