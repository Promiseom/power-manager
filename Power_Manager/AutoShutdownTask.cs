using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;

namespace Power_Manager
{   
    /// <summary>
    /// A single shutdown task. 
    /// Each shutdown task contains the following:
    /// Shutdown Passwor, is left blank if not set,
    /// Shutdown Message, is left blank if not set,
    /// Countdown visibility so the countdown can be visible to the user of hidden.
    /// Countdown window invisibility timeout so the countdown can reappear after sometime after being hidden.
    /// </summary>
    public class AutoShutdownTask : IShutdownTask
    {        
        private SHUTDOWNACTION shutdownAction; //holds the index of the combo box containing the shutdown action to be performed
        private int shutdownTime;                      //time to wait before performing shutdown
        private string shutdownPassword;          //if not null, must be provided, to cancel shutdown
        private string shutdownMessage;           //message to be displayed before shutdown if provided
        private bool isProtected;                 //set to true if the task is passwordd protected

        //determines of the countdown window visible
        //if set to be invisible, the user will have to set the time from 0 to set time
        //when the window should appear, this is mandatory
        private bool isCountdownVisible;
        private int invisibilityTimeTout;
        private int countDownTimer;
        private bool isCountDownStarted;        //true if the countdown has started

        //handles countdown concurrency        
        private BackgroundWorker backgroundWorker;
        private CountDownWindow cdWindow;

        private ITaskManager taskListener;

        public int ShutdownTime { set { shutdownTime = value; } get { return shutdownTime; } }
        public string ShutdownMessage 
        { 
            set 
            {
                if (value.Length >= 1)
                {
                    shutdownMessage = value;
                }                 
            } 
            get 
            { 
                return shutdownMessage; 
            } 
        }
   
        //creates a simple shutdown with action and time
        public AutoShutdownTask(SHUTDOWNACTION shutdownAction, int shutdownTime)
        {
            isProtected = false;
            this.shutdownAction = shutdownAction;
            this.shutdownTime = shutdownTime;
            this.countDownTimer = shutdownTime;
            this.isCountDownStarted = false;
            this.backgroundWorker = new BackgroundWorker();
        
            //prepare the backgroundworker
            backgroundWorker.WorkerReportsProgress = true;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.DoWork += new DoWorkEventHandler(backgroundWorker_DoWork);
            backgroundWorker.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker_ProgressChanged);
            backgroundWorker.RunWorkerAsync();
        }

        //creates an auto shutdown task with additional shutdown password and shutdown message
        public AutoShutdownTask(SHUTDOWNACTION shutdownAction, int shutdownTime, string shutdownPassword, string shutdownMessage) : this(shutdownAction, shutdownTime)
        {
            isProtected = true;
            this.shutdownPassword = shutdownPassword;
        }

        public void SetITaskListener(ITaskManager newListener)
        {
            taskListener = newListener;
        }

        public bool ChangeShutdownPassword(string pwd)
        {
            //cannot change password after shutdown has started
            if (isCountDownStarted) { return false; }
            //ignore empty passwords
            if (pwd.Length <= 0) { return false; }

            this.shutdownPassword = pwd;
            isProtected = true;
            return true;
        }

        public void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if(isCountDownStarted)
                {
                    countDownTimer--;
                    backgroundWorker.ReportProgress(countDownTimer);                    
                }
                Thread.Sleep(1000);
            }            
        }

        public void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //if the countdown window is invisible
            //make it visible at the right time
            if(!isCountdownVisible)
            {
                if(countDownTimer == invisibilityTimeTout)
                {
                    isCountdownVisible = true;
                    cdWindow.Visible = isCountdownVisible;
                }
            }

            if (countDownTimer < 0)
            {
                isCountDownStarted = false;
                if (taskListener != null)
                {
                    isProtected = false;
                    cdWindow.Close();
                    ShutdownManager.Shutdown(shutdownAction);                    
                    taskListener.OnTaskCompleted(this);
                }
                //prevent the display of negative number
                return;
            }
            cdWindow.SetTimer(countDownTimer);            
        }

        public bool Start()
        {           
            //set the timer            
            countDownTimer = shutdownTime;
            isCountDownStarted = true;

            //create and display the shutdown window
            cdWindow = new CountDownWindow(this);
            cdWindow.Show((Form)taskListener);

            //if the countdown window is invisible, it should not show in the taskbar
            cdWindow.Visible = isCountdownVisible;
            cdWindow.ShowInTaskbar = isCountdownVisible;
            cdWindow.SetTimer(shutdownTime);

            if (this.shutdownMessage != null)
            {
                cdWindow.SetMessage(this.shutdownMessage);
            }

            if (taskListener != null)
            {
                taskListener.OnTaskStarted(this);
            }
            return isCountDownStarted;
        }

        public void SetCountdownVisibility(bool value)
        {
            isCountdownVisible = value;
            //inform tasklistener about the visibility change
            taskListener.OnTaskValueChanged(TASKVALUES.WINDOW_VISIBILITY, isCountdownVisible);
        }

        /// <summary>
        /// Called to hide the countdown window.
        /// When this function is called, the invisibility timeout has to be set
        /// </summary>
        /// <param name="value"></param>
        public void SetCountdownVisibility(bool value, int invisibilityTimout)
        {
            SetCountdownVisibility(value);
            this.invisibilityTimeTout = invisibilityTimout;
        }

        /// <summary>
        /// Aborts an autoshutdown task that has been started
        /// Throws AbortFailedException is attempting to abort a protected task
        /// </summary>
        public bool Abort()
        {
            if (isProtected)
            {
                throw new AbortFailedException("A password is required to abort a protected shutdown task, no password provided. Consider using Abort(string)");
            }

            isCountDownStarted = false;
            backgroundWorker.CancelAsync();
            if (taskListener != null)
            {
                taskListener.OnTaskAborted(this);
            }            
            return true;
        }

        public bool Abort(string pwd)
        {
            if (isProtected)
            {
                if (pwd == shutdownPassword)
                {
                    //remove protection since the password is correct
                    isProtected = false;  
                    Abort();
                    return true;
                }
                return false;
            }
            //ignore password
            return true;
        }

        public bool IsTaskProtected()
        {
            return isProtected;
        }

        public bool IsTaskRunning()
        {
            return isCountDownStarted;
        }
    }
}
