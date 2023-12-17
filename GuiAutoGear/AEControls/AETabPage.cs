using System.Windows.Automation;

namespace GuiAutoGear.AEControls
{
    public class AETabPage : AEControlBase
    {
        public string TabName { get => mElement.Current.Name; }

        public AETabPage(AutomationElement automationElement)
            : base(automationElement)
        {
        }

        public AETabPage(AutomationElement rootElement, string automationId)
            : base(rootElement, automationId)
        {
        }

        public AETabPage(AEControlBase rootCtrl, string automationId)
            : base(rootCtrl, automationId)
        {
        }
    }
}
