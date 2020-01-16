using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Manager
{
    public class AbortFailedException : ApplicationException
    {
        public AbortFailedException(string message) : base(message)
        {
            
        }
    }

    public class InvalidPasswordException : ApplicationException
    {
        public InvalidPasswordException(string message) : base(message)
        {

        }
    }

    public interface IShutdownTask
    {
        /// <summary>
        /// Starts the countdown
        /// </summary>
        bool Start();
        /// <summary>
        /// Aborts task without password
        /// </summary>
        bool Abort();
        /// <summary>
        /// Aborts shutdown task that is password protected
        /// </summary>
        /// <param name="pwd"></param>
        bool Abort(string pwd);
        /// <summary>
        /// Sets if the shutdown task can be cancelled or not.
        /// </summary>
        /// <param name="canCancel">Boolean value to determine if the task can cancelled or not</param>
        void SetIsCancellable(bool canCancel);
        bool IsTaskCancellable();
        bool IsTaskProtected();
        bool IsTaskRunning();
        void SetCountdownVisibility(bool value, int invisibilityTimeout);
    }
}
