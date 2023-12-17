using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuiAutoGear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;
using GuiAutoGear.AEControls;

namespace GuiAutoGear.Tests
{
    [TestClass()]
    public class AEWindowTests
    {
        [TestMethod()]
        public void 対象プロセスのWindowを取得できること()
        {
            // サンプルプログラムを起動
            var sampleProc = Process.Start(@"..\..\..\SampleGuiAuto\bin\Debug\SampleGuiAuto.exe");
            bool isException = false;

            Thread.Sleep(1000);

            try
            {
                var aeWindow = new AEWindow("Form1");

                Assert.IsNotNull(aeWindow);
                Assert.AreEqual("Form1", aeWindow.WindowName);
            }
            catch { isException = true; }
            finally
            {
                // サンプルプログラムを終了
                sampleProc.Kill();

                Assert.IsFalse(isException);
            }
        }

        [TestMethod]
        [DataRow(0, 0)]
        [DataRow(100, 100)]
        [DataRow(100, 200)]
        [DataRow(200, 100)]
        [DataRow(500, 500)]
        [DataRow(1000, 500)]
        public void Windowの位置を変更できること(int x, int y)
        {
            // サンプルプログラムを起動
            var sampleProc = Process.Start(@"..\..\..\SampleGuiAuto\bin\Debug\SampleGuiAuto.exe");

            Thread.Sleep(1000);

            try
            {
                var aeWindow = new AEWindow("Form1");

                aeWindow.SetLocation(0, 0);
                for (int iX = 0; iX <= x; iX++)
                {
                    aeWindow.SetLocation(iX, 0);
                }
                for (int iY = 0; iY <= y; iY++)
                {
                    aeWindow.SetLocation(x, iY);
                }

                var pos = aeWindow.GetLocation();
                Assert.AreEqual(x, pos.X);
                Assert.AreEqual(y, pos.Y);

                Thread.Sleep(1000);
            }
            catch { throw; }
            finally
            {
                // サンプルプログラムを終了
                sampleProc.Kill();
            }
        }

        [TestMethod]
        public void 部品ID一覧を取得できること()
        {
            // サンプルプログラムを起動
            var sampleProc = Process.Start(@"..\..\..\SampleGuiAuto\bin\Debug\SampleGuiAuto.exe");

            Thread.Sleep(1000);

            try
            {
                var aeWindow = new AEWindow("Form1");

                var ctrlList = aeWindow.GetCtrlIdList();
                foreach(var id in ctrlList)
                {
                    Trace.WriteLine(id);
                }
                Assert.IsTrue(ctrlList.Count > 0);
            }
            catch { throw; }
            finally
            {
                // サンプルプログラムを終了
                sampleProc.Kill();
            }
        }

        [TestMethod]
        public void テキストボックスに値を入力できること()
        {
            // サンプルプログラムを起動
            var sampleProc = Process.Start(@"..\..\..\SampleGuiAuto\bin\Debug\SampleGuiAuto.exe");

            Thread.Sleep(1000);

            try
            {
                var aeWindow = new AEWindow("Form1");

                var textBox = new AETextBox(aeWindow, "txtInput");

                Assert.AreEqual("", textBox.Text);
                textBox.Text = "abcde";
                Assert.AreEqual("abcde", textBox.Text);
            }
            catch { throw; }
            finally
            {
                Thread.Sleep(5000);

                // サンプルプログラムを終了
                sampleProc.Kill();
            }
        }


        [TestMethod]
        public void テキストボックスに値を入力できること_2()
        {
            // サンプルプログラムを起動
            var sampleProc = Process.Start(@"..\..\..\SampleGuiAuto\bin\Debug\SampleGuiAuto.exe");

            Thread.Sleep(1000);

            try
            {
                var aeWindow = new AEWindow("Form1");

                var textBox = new AETextBox(aeWindow, "mTxtFormName");

                Assert.AreEqual("", textBox.Text);
                textBox.Text = "Form1";
                Assert.AreEqual("Form1", textBox.Text);

                var button = new AEButton(aeWindow, "mBtnFindForm");
                button.Click();
            }
            catch { throw; }
            finally
            {
                Thread.Sleep(5000);

                // サンプルプログラムを終了
                sampleProc.Kill();
            }
        }


        [TestMethod]
        public void コントロール一覧取得ボタンを押して_リストボックスのアイテムを取得できること()
        {
            // サンプルプログラムを起動
            var sampleProc = Process.Start(@"..\..\..\SampleGuiAuto\bin\Debug\SampleGuiAuto.exe");

            Thread.Sleep(1000);

            try
            {
                // Formの取得
                var aeWindow = new AEWindow("Form1");

                // 一覧取得ボタン押下
                var button = new AEButton(aeWindow, "mBtnCtrlList");
                button.Click();

                // ListBoxを取得
                var listBox = new AEListBox(aeWindow, "mLstCtrlList");
                Assert.IsNotNull(listBox);
                Assert.AreEqual(49, listBox.Items.Count);
                Assert.IsTrue(listBox.Items.Any(i => i.Name == "mBtnCtrlList"));
                Assert.IsTrue(listBox.Items.Any(i => i.Name == "mLstCtrlList"));
                
                Assert.AreEqual(-1, listBox.SelectedIndex);

                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    try
                    {
                        Trace.WriteLine($"[{i}] = {listBox.Items[i].Text}");
                        listBox.SelectedIndex = i;
                        Assert.AreEqual(i, listBox.SelectedIndex);
                    }
                    catch { }
                }
            }
            catch { throw; }
            finally
            {
                //Thread.Sleep(5000);

                // サンプルプログラムを終了
                sampleProc.Kill();
            }
        }

        [TestMethod]
        public void コンボボックスのアイテム選択と()
        {
            // サンプルプログラムを起動
            var sampleProc = Process.Start(@"..\..\..\SampleGuiAuto\bin\Debug\SampleGuiAuto.exe");

            Thread.Sleep(1000);

            try
            {
                // Formの取得
                var aeWindow = new AEWindow("Form1");

                // 一覧取得ボタン押下
                var button = new AEButton(aeWindow, "mBtnCtrlList");
                button.Click();

                // ListBoxを取得
                var cmbBox = new AEComboBox(aeWindow, "cmbBox");
                Assert.IsNotNull(cmbBox);
                Assert.AreEqual(5, cmbBox.Items.Count);
#if TBD
                Assert.IsTrue(listBox.Items.Any(i => i.Name == "mBtnCtrlList"));
                Assert.IsTrue(listBox.Items.Any(i => i.Name == "mLstCtrlList"));

                Assert.AreEqual(-1, listBox.SelectedIndex);

                for (int i = 0; i < listBox.Items.Count; i++)
                {
                    try
                    {
                        Trace.WriteLine($"[{i}] = {listBox.Items[i].Text}");
                        listBox.SelectedIndex = i;
                        Assert.AreEqual(i, listBox.SelectedIndex);
                    }
                    catch { }
                }
#endif
            }
            catch { throw; }
            finally
            {
                //Thread.Sleep(5000);

                // サンプルプログラムを終了
                sampleProc.Kill();
            }
        }

        [TestMethod]
        public void チェックリストボックスのアイテムを制御できること()
        {
            // サンプルプログラムを起動
            var sampleProc = Process.Start(@"..\..\..\SampleGuiAuto\bin\Debug\SampleGuiAuto.exe");

            Thread.Sleep(1000);

            try
            {
                // Formの取得
                var aeWindow = new AEWindow("Form1");

                // CheckedListBoxを取得
                var checkedListBox = new AECheckedListBox(aeWindow, "checkedListBox1");
                Assert.IsNotNull(checkedListBox);
                Assert.AreEqual(5, checkedListBox.Items.Count);
                Assert.IsTrue(checkedListBox.Items.Any(i => i.Name == "CheckList1"));
                Assert.IsTrue(checkedListBox.Items.Any(i => i.Name == "CheckList5"));

                Assert.AreEqual(-1, checkedListBox.SelectedIndex);

                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    Trace.WriteLine($"[{i}] = {checkedListBox.Items[i].Text}");
                    checkedListBox.SelectedIndex = i;
                    Assert.AreEqual(i, checkedListBox.SelectedIndex);
                    checkedListBox.Check(i, true);
                }

                for (int i = 0; i < checkedListBox.Items.Count; i++)
                {
                    Trace.WriteLine($"[{i}] = {checkedListBox.Items[i].Text} {checkedListBox.IsChecked(i)}");
                }
            }
            catch { throw; }
            finally
            {
                //Thread.Sleep(5000);

                // サンプルプログラムを終了
                sampleProc.Kill();
            }
        }
    }
}