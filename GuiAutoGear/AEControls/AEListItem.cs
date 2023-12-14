using System.Windows.Automation;

namespace GuiAutoGear.AEControls
{
    public class AEListItem : AEControlBase
    {
        public int Index { get; protected set; } = -1;
        public string Text { get { return mElement.Current.Name; } }
        public AEListItem(AutomationElement automationElement, int index)
            : base(automationElement)
        {
            Index = index;
        }

        public AEListItem(AutomationElement rootElement, string automationId, int index)
            : base(rootElement, automationId)
        {
            Index = index;
        }
    }
}
