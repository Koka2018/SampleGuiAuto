using System;
using System.Text;
using System.Drawing;
using System.Windows.Automation;

namespace GuiAutoGear.AEControls
{
    public class AEControlBase
    {
        #region メンバ変数

        protected AutomationElement mElement = null;

        #endregion

        #region プロパティ

        public string AutomationId { get { return mElement.Current.AutomationId; } }

        public string Name { get { return mElement.Current.Name; } }

        public ControlType Type { get { return mElement.Current.ControlType; } }

        public AutomationElement Element => mElement;

        public Rectangle Rect
        {
            get
            {
                return new Rectangle(
                    (int)mElement.Current.BoundingRectangle.X,
                    (int)mElement.Current.BoundingRectangle.Y,
                    (int)mElement.Current.BoundingRectangle.Width,
                    (int)mElement.Current.BoundingRectangle.Height);
            }
        }

        public bool Enable { get { return mElement.Current.IsEnabled; } }

        public bool IsFocus { get { return mElement.Current.HasKeyboardFocus; } }

        protected ValuePattern ValuePattern { get { return mElement.GetValuePattern(); } }

        protected InvokePattern InvokePattern { get { return mElement.GetInvokePattern(); } }

        protected ExpandCollapsePattern ExpandCollapsePattern { get { return mElement.GetExpandCollapsePattern(); } }

        protected TogglePattern TogglePattern { get { return mElement.GetTogglePattern(); } }

        protected SelectionItemPattern SelectionItemPattern { get { return mElement.GetSelectionItemPattern(); } }

        #endregion

        public AEControlBase(AutomationElement automationElement)
        {
            mElement = automationElement;
        }

        public AEControlBase(AutomationElement rootElement, string automationId)
        {
            mElement = rootElement.FindElement(automationId);
        }

        public AEControlBase(AEControlBase rootCtrl, string automationId)
        {
            mElement = rootCtrl.mElement.FindElement(automationId);
        }

        #region メソッド

        public void Focus()
        {
            SelectionItemPattern.Select();
        }

        public override string ToString()
        {
            try
            {
                var sb = new StringBuilder();
                sb.AppendLine("=====");
                sb.AppendLine($"AutomationId = {AutomationId}");

                //sb.AppendLine(Name);
                sb.AppendLine($"Type = {Type}");
                sb.AppendLine($"Rect = {Rect}");
                return sb.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        #endregion
    }
}
