using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace GuiAutoGear
{
    public class AEWindow
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public static IntPtr FindWindow(string windowName)
        {
            IntPtr windowHandle = FindWindow(null, windowName);
            if (windowHandle != IntPtr.Zero)
            {
                Console.WriteLine("ウィンドウハンドル: " + windowHandle.ToString());
            }
            else
            {
                Console.WriteLine("ウィンドウが見つかりませんでした。");
            }
            return windowHandle;
        }
    }
}
