using System.Windows.Automation;

namespace GuiAutoGear.AEControls
{
    public class AERadioButton : AEControlBase
    {
        public bool Checked { get { return SelectionItemPattern.Current.IsSelected; } }

        public AERadioButton(AutomationElement automationElement)
            : base(automationElement)
        {
        }

        public AERadioButton(AutomationElement rootElement, string automationId)
            : base(rootElement, automationId)
        {
        }

        public void Select()
        {
            SelectionItemPattern.Select();
        }
    }
}
