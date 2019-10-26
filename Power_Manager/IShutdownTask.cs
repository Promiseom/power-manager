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

        bool IsTaskProtected();
        bool IsTaskRunning();
    }
}
