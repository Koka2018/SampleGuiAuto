using System.Windows.Automation;

namespace GuiAutoGear.AEControls
{
    public class AEButton : AEControlBase
    {
        public string Text { get { return ValuePattern.Current.Value; } }

        public AEButton(AutomationElement automationElement)
            : base(automationElement)
        {
        }

        public AEButton(AutomationElement rootElement, string automationId)
            : base(rootElement, automationId)
        {
        }

        public void Click()
        {
            InvokePattern.Invoke();
        }
    }
}
