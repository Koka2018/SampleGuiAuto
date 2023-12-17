using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuiAutoGear.ProcessTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace GuiAutoGear.ProcessTools.Tests
{
    [TestClass()]
    public class ProcessParserTests
    {
        [TestMethod()]
        public void プロセス一覧が取得できること()
        {
            // サンプルプログラムを起動
            var sampleProc = Process.Start(@"..\..\..\SampleGuiAuto\bin\Debug\SampleGuiAuto.exe");

            Thread.Sleep(1000);

            // プロセス一覧を取得
            var procList = ProcessParser.GetProcessList();

            // 取得したプロセス一覧を列挙
            foreach(var proc in procList)
            {
                Trace.WriteLine(proc.MainWindowTitle);
            }

            // サンプルプログラムを終了
            sampleProc.Kill();

            Assert.AreNotEqual(0, procList.Count);
            Assert.IsTrue(procList.Any(p => p.MainWindowTitle == "Form1"));
        }
    }
}