using System.Windows.Automation;

namespace GuiAutoGear.AEControls
{
    public class AECheckBox : AEControlBase
    {
        public bool Checked
        {
            get => TogglePattern.Current.ToggleState == ToggleState.On;
            set
            {
                if(value == Checked) { return; }
                TogglePattern.Toggle();
            }
        }

        public AECheckBox(AutomationElement automationElement)
            : base(automationElement)
        {
        }

        public AECheckBox(AutomationElement rootElement, string automationId)
            : base(rootElement, automationId)
        {
        }
    }
}
