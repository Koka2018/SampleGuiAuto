using System.Drawing;
using System.Windows.Automation;

namespace GuiAutoGear.AEControls
{
    public class AEControlBase
    {
        protected AutomationElement mElement = null;

        public string AutomationId { get { return mElement.Current.AutomationId; } }

        public string Name { get { return mElement.Current.Name; } }

        public ControlType Type { get { return mElement.Current.ControlType; } }

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

        public AEControlBase(AutomationElement automationElement)
        {
            mElement = automationElement;
        }

        public AEControlBase(AutomationElement rootElement, string automationId)
        {
            mElement = rootElement.FindElement(automationId);
        }

        public void Focus()
        {
            mElement.SetFocus();
        }

        public override string ToString()
        {
            return $"ID={AutomationId},Name={Name},Type={Type},Rect={Rect}";
        }
    }
}
