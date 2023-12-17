using GuiAutoGear;
using GuiAutoGear.AEControls;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Automation;
using System.Windows.Forms;

namespace SampleGuiAuto
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        #region イベント

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 入力された文字列をリストボックスへ追加
            lstResults.Items.Add(txtInput.Text);
            cmbBox.Items.Add(txtInput.Text);

            // 入力用テキストボックスを空に設定
            txtInput.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Automation();
        }

        #endregion

        public static void Automation()
        {
            var proc = Process.Start(@".\SampleGuiAuto.exe");
            try
            {
                Thread.Sleep(1000);
                var aeForm = AutomationElement.FromHandle(proc.MainWindowHandle);

                //var a = AEWindow.GetLocation(aeForm);
                //MessageBox.Show($"{a.X}, {a.Y}");

                // 操作対象のコントロールへの参照を
                // AutomationElementオブジェクトとして取得
                var tabCtrl = new AETabControl(aeForm);
                tabCtrl.TabPages[1].Focus();
                var childBtn = new AEButton(aeForm, "childButton");
                tabCtrl.TabPages[0].Focus();


                var txtInput = new AETextBox(aeForm, "txtInput");
                var btnAdd = new AEButton(aeForm, "btnAdd");
                var lstResults = new AEListBox(aeForm, "lstResults");
                var cmbBox = new AEComboBox(aeForm, "cmbBox");

                var chkBox = new AECheckBox(aeForm, "chkBox");
                chkBox.Checked = true;
                chkBox.Checked = false;

                var rdo1 = new AERadioButton(aeForm, "rdoBtn1");
                var rdo2 = new AERadioButton(aeForm, "rdoBtn2");
                rdo2.Select();
                rdo1.Select();

                foreach(AutomationElement elem in aeForm.FindAllElements(true))
                {
                    var aeCtrl = new AEControlBase(elem);
                    Console.WriteLine(aeCtrl.ToString());
                }
#if TBD
                var numUD = new AETextBox(aeForm, "numUpDown");
                numUD.Text = "3";
#endif

                // 1つ目の値を入力、［追加］ボタン押下
                txtInput.Text = "ねこ";
                btnAdd.Click();

                // 2つ目の値を入力、［追加］ボタン押下
                txtInput.Text = "いぬ";
                btnAdd.Click();

                // 3つ目の値を入力、［追加］ボタン押下
                txtInput.Text = "さる";
                btnAdd.Click();

                // 4つ目の値を入力
                txtInput.Text = "きじ";

                // リストボックスの値を取得するため、
                // AutomationElementCollectionオブジェクトを取得
                Console.WriteLine("=== ListBox ====");
                foreach(var item in lstResults.Items)
                {
                    Console.WriteLine(item.Text);
                }
#if TBD
                Console.WriteLine("=== CombotBox ====");
                foreach (var item in cmbBox.Items)
                {
                    Console.WriteLine(item.Text);
                }
#endif

                // リストの選択
                lstResults.Items[2].Focus();
                //cmbBox.Text = "いぬ";
                txtInput.Focus();
                MessageBox.Show($"選択={lstResults.SelectedIndex} {lstResults.SelectedText}");

                MessageBox.Show($"テキスト={txtInput.Text}");
            }
            finally
            {
                MessageBox.Show("Fin.");
                proc.Kill();
            }
        }

        private void mBtnFindForm_Click(object sender, EventArgs e)
        {
            var windowName = mTxtFormName.Text;
            var windowHandle = AEWindow.FindWindowHandle(windowName);

            if(windowHandle == IntPtr.Zero)
            {
                MessageBox.Show("画面が見つかりませんでした。");
            }
            var aeForm = AutomationElement.FromHandle(windowHandle);
            aeForm.ShowInfo();
        }

        private void mBtnCtrlList_Click(object sender, EventArgs e)
        {
            var form = new AEWindow("Form1");
            var ctrlList = form.GetCtrlIdList();

            foreach(var ctrl in ctrlList)
            {
                mLstCtrlList.Items.Add(ctrl);
            }
        }
    }
}
