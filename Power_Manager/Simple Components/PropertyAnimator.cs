using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace SimpleComponents
{
    public enum AnimeProperty{SIZE_HEIGHT, SIZE_WIDTH, SIZE, LOCATION};
    public enum Interpolation{LINEAR_INTERPOLATION};
    public enum RepeatMode{NO_REPEAT, REPEAT_ONCE, REPEAT_ALWAYS};

    /// <summary>
    /// The PropertyAnimator animates specific properties of an object.
    /// This class works with only 2 type of objects, Forms and Controls types.
    /// 
    /// For the properties of an object to be animated, the object must have the 
    /// property that has been chosen to animate.
    /// 
    /// The only fields that can be animated are fields that have a numeric mode of representation.
    /// </summary>
    public class PropertyAnimator
    {
        private dynamic animeObject;                   //object to animate (must be System.Windows.Forms or System.Windows.Forms.Control).
        private AnimeProperty property;                //propery of the object to animate
        private Interpolation interpolation;           //determines acceleration of the animation.
        private int duration;                          //(milliseconds), how long the animation will last
        private RepeatMode repeatMode;                 //determines of the animation should repeat and is so how should it repeat.
        //callback goes here
        private dynamic startInt, endInt;
        private double rate;

        //is the animation currently running or not,
        //animation is running when it is paused
        private bool isRunning;
        //an animation cannot be stopped if it has not been started
        //or has previously been stopped
        private bool isStopped;

        private BackgroundWorker animationPlayBack;
        private IAnimatorListener mListener;

        public object AnimeObject { get { return this.animeObject; } set { animeObject = value; } }
        public AnimeProperty AnimeProperty { get { return this.property; } set { this.property = value; } }
        public Interpolation AnimeInterpolation { get { return this.interpolation; } set { this.interpolation = value; } }
        public int AnimeDuration { get { return this.duration; } set { this.duration = value; } }
        public RepeatMode RepeatMode { get { return this.repeatMode; } set { this.repeatMode = value; } }
        public dynamic StartValue { get { return this.startInt; } set { this.startInt = value; } }
        public dynamic EndValue { get { return this.endInt; } set { this.endInt = value; } }
        public IAnimatorListener AnimatorListener { set { this.mListener = value; } }

        private PropertyAnimator()
        {
            //default values
        }

        public PropertyAnimator(dynamic anime, AnimeProperty prop, dynamic startVal, dynamic endVal, int duration) : this()
        {
            this.animeObject = anime;
            
            //make sure the object is of a valid type
            if (!(this.animeObject is Form || this.animeObject is Control))
            {
                throw new ArgumentException("Invalid Argument! Only objects of type System.Windows.Forms and System.Windows.Forms.Controls can be animated.");
            }

            this.property = prop;
            this.duration = duration;
            this.startInt = startVal;
            this.endInt = endVal;

            this.isRunning = false;
            this.isStopped = true;

            rate = ((endInt - startInt) >= 0) ? 1 : -1;

            //prepare the background task
            animationPlayBack = new BackgroundWorker();
            animationPlayBack.WorkerSupportsCancellation = true;
            animationPlayBack.WorkerReportsProgress = true;
            
            animationPlayBack.DoWork += new DoWorkEventHandler(DoBackgroundWork);
            animationPlayBack.ProgressChanged += new ProgressChangedEventHandler(ReportProgress);
            animationPlayBack.RunWorkerCompleted += new RunWorkerCompletedEventHandler(OnWorkCompleted);    
        }

        public void Start()
        {
            isRunning = true;
            isStopped = false;
            animationPlayBack.RunWorkerAsync();
            mListener.OnStart();
        }

        public void Pause()
        {
            if(isStopped) { return; }
            isRunning = false;
            mListener.OnPause();
        }

        public void Resume()
        {
            if(isStopped) { return; }
            isRunning = true;
            mListener.OnResume();
        }

        public void Stop()
        {
            isRunning = false;
            isStopped = true;
            animationPlayBack.CancelAsync();
            mListener.OnStop();
        }
        
        public void DoBackgroundWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                if (isRunning)
                {
                    animationPlayBack.ReportProgress(0);     //we're not really reporting progess change
                    if((startInt += (int)rate) == endInt)
                    {
                        break;
                    }
                    //rate += 0.015;
                }
                Thread.Sleep(1);  
            }
        }

        public void ReportProgress(object sender, ProgressChangedEventArgs e)
        {
            //make appropriate change to the objects property

            //!!!!!!!!!!!!!!!TESTING!!!!!!!!!!!!!!!!!!!!
            //USING ONLY HEIGHT IN THIS TEST
            animeObject.Height = animeObject.Height + (int)rate;
            //MessageBox.Show(rate.ToString(), "Finished");
        }

        public void OnWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //MessageBox.Show("Animation Complete", "Finished");
            mListener.OnComplete();
        }
    }
}