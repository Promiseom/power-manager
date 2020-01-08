using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Manager
{
    public enum TASKVALUES { TIME_REMAINING, WINDOW_VISIBILITY };

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

        /// <summary>
        /// Called by the Shutdown Task when the value of some task property has changed.
        /// 
        /// The task creator will have to implement this method to be
        /// informed when this values change.
        /// 
        /// Please note that the implementer to this is responsible for checking to,
        /// make sure the value passed in matches the type specified, and 
        /// taking appropriate action if value is does not match expected type for the task property
        /// </summary>
        /// <param name="tkValue">Identifies the task property that has been modified.</param>
        /// <param name="newValue">Is the new value of the task proerty.</param>
        void OnTaskValueChanged(TASKVALUES tkValue, dynamic newValue);
    }
}
