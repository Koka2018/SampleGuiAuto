using System.Windows.Automation;

namespace GuiAutoGear.AEControls
{
    public class AETextBox : AEControlBase
    {
        public string Text
        {
            get { return ValuePattern.Current.Value; }
            set { ValuePattern.SetValue(value); }
        }

        public AETextBox(AutomationElement automationElement)
            : base(automationElement)
        {
        }

        public AETextBox(AutomationElement rootElement, string automationId)
            : base(rootElement, automationId)
        {
        }

        public override string ToString()
        {
            return $"{base.ToString()},Text={Text}";
        }
    }
}
