using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Automation;
using GuiAutoGear.AEControls;

namespace GuiAutoGear
{
    public class AEWindow : AEControlBase
    {
        #region DLLインポート

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern int MoveWindow(IntPtr hwnd, int x, int y,
            int nWidth, int nHeight, int bRepaint);

        #endregion

        #region メンバ変数

        private IntPtr mWindowHandle = IntPtr.Zero;

        #endregion

        #region プロパティ

        public string WindowName { get; protected set; } = string.Empty;

        #endregion

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="windowName">画面タイトル</param>
        public AEWindow(string windowName) : base(null)
        {
            WindowName = windowName;
            mWindowHandle = FindWindowHandle(windowName);
            if(mWindowHandle == IntPtr.Zero) { throw new Exception("Windowが見つかりませんでした。"); }

            mElement = AutomationElement.FromHandle(mWindowHandle);
        }

        public static IntPtr FindWindowHandle(string windowName)
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

        public (double X, double Y) GetLocation()
        {
            var pos = mElement.Current.BoundingRectangle.Location;
            return (pos.X, pos.Y);
        }

        public void SetLocation(int x, int y)
        {
            var size = mElement.Current.BoundingRectangle.Size;
            MoveWindow(mWindowHandle, x, y, (int)size.Width, (int)size.Height, 1);
        }

        public List<string> GetCtrlIdList()
        {
            var elements = mElement.FindAllElements(true);
            var elementList = new List<string>();

            foreach(AutomationElement elem in elements)
            {
                elementList.Add(elem.Current.AutomationId);
            }
            return elementList;
        }
    }
}
