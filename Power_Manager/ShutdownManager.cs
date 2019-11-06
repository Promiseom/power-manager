using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Power_Manager
{
    public enum SHUTDOWN_TYPE { SHUTDOWN_NORMAL, SHUTDOWN_POWER_LOSS };
    public enum SHUTDOWNACTION { SLEEP, HIBERNATE, LOGOFF, SHUTDOWN };
    public enum SHUTDOWN_ACTION_POWER_LOSS { PROMPT_FOR_ACTION, NOTHING, SLEEP, HIBERNATE, SHUTDOWN };
    
    public class ShutdownManager
    {    
        public static string[] GetShutdownActions(SHUTDOWN_TYPE type)
        {
            if (type == SHUTDOWN_TYPE.SHUTDOWN_NORMAL)
            {
                string[] objs = new string[4];
                objs[0] = SHUTDOWNACTION.SLEEP.ToString();
                objs[1] = SHUTDOWNACTION.HIBERNATE.ToString();
                objs[2] = SHUTDOWNACTION.LOGOFF.ToString();
                objs[3] = SHUTDOWNACTION.SHUTDOWN.ToString();
                return objs;
            }

            string[] obj = new string[5];
            obj[0] = SHUTDOWN_ACTION_POWER_LOSS.PROMPT_FOR_ACTION.ToString();
            obj[1] = SHUTDOWN_ACTION_POWER_LOSS.NOTHING.ToString();
            obj[2] = SHUTDOWN_ACTION_POWER_LOSS.SLEEP.ToString();
            obj[3] = SHUTDOWN_ACTION_POWER_LOSS.HIBERNATE.ToString();
            obj[4] = SHUTDOWN_ACTION_POWER_LOSS.SHUTDOWN.ToString();
            return obj;
        }



        public static void Shutdown(SHUTDOWNACTION action)
        {
            switch (action)
            {
                case SHUTDOWNACTION.SLEEP:
                    Application.SetSuspendState(PowerState.Suspend, true, false);
                    //MessageBox.Show("Putting computer to sleep", "Note");
                    break;
                case SHUTDOWNACTION.HIBERNATE:
                    Application.SetSuspendState(PowerState.Hibernate, true, false);
                    //MessageBox.Show("Hibernating computer", "Note");
                    break;
                case SHUTDOWNACTION.LOGOFF:
                    Process.Start(@"..\cmd_shutdown\logoff.exe");
                    //MessageBox.Show("Logging off user", "Note");
                    break;
                case SHUTDOWNACTION.SHUTDOWN:
                    Process.Start(@"..\cmd_shutdown\shutdown.exe");
                    //MessageBox.Show("System is shutting down", "Note");
                    break;
            }
        }

        public static void Shutdown(SHUTDOWN_ACTION_POWER_LOSS action)
        {
            switch (action)
            {
                case SHUTDOWN_ACTION_POWER_LOSS.SLEEP:
                    Application.SetSuspendState(PowerState.Suspend, true, false);
                    break;
                case SHUTDOWN_ACTION_POWER_LOSS.HIBERNATE:
                    Application.SetSuspendState(PowerState.Hibernate, true, false);
                    break;
                case SHUTDOWN_ACTION_POWER_LOSS.SHUTDOWN:
                    Process.Start(@"..\cmd_shutdown\shutdown.exe");
                    break;
            }
        }
    }
}
