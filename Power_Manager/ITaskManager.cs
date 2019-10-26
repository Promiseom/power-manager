using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Manager
{
    public interface ITaskManager
    {
        /// <summary>
        /// Called by the IShutdownTask when the task has been completed
        /// </summary>
        /// <returns>true so child can close, returns false so child can remain open</returns>
        void OnTaskCompleted(IShutdownTask task);

        /// <summary>
        /// Called by the IShutdownTask when the task has been cancelled
        /// </summary>
        /// <param name="taskManager"></param>
        /// <returns></returns>
        void OnTaskAborted(IShutdownTask task);

        /// <summary>
        /// Called by the IShutdownTask when the task has started.
        /// </summary>
        /// <param name="task"></param>
        void OnTaskStarted(IShutdownTask task);
    }
}
