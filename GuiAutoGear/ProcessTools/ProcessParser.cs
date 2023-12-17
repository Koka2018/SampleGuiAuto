using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiAutoGear.ProcessTools
{
    public static class ProcessParser
    {
        public static List<Process> GetProcessList()
        {
            var procList = Process.GetProcesses().ToList();
            procList.RemoveAll(p => p.MainWindowTitle.Length == 0);
            return procList;
        }
    }
}
