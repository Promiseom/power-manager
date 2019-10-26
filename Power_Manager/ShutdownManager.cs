using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Power_Manager
{
    public class ShutdownManager
    {
        public enum SHUTDOWNACTION { SLEEP, HIBERNATE, LOGOFF, SHUTDOWN };

        public static string[] GetShutdownActions()
        {
            string[] objs = new string[4];
            objs[0] = SHUTDOWNACTION.SLEEP.ToString();
            objs[1] = SHUTDOWNACTION.HIBERNATE.ToString();
            objs[2] = SHUTDOWNACTION.LOGOFF.ToString();
            objs[3] = SHUTDOWNACTION.SHUTDOWN.ToString();
            return objs;
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
    }
}
