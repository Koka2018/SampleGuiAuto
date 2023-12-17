using System.Collections.Generic;
using System.Windows.Automation;

namespace GuiAutoGear.AEControls
{
    public class AETabControl : AEControlBase
    {
        public List<AETabPage> TabPages { get => GetTabPages(); }

        public int SelectedIdx { get => GetSelectedIndex(); }

        public AETabControl(AutomationElement automationElement)
            : base(automationElement)
        {
        }

        public AETabControl(AutomationElement rootElement, string automationId)
            : base(rootElement, automationId)
        {
        }

        public AETabControl(AEControlBase rootCtrl, string automationId)
            : base(rootCtrl, automationId)
        {
        }

        protected List<AETabPage> GetTabPages()
        {
            var tabPageList = new List<AETabPage>();
            foreach (AutomationElement ctrl in mElement.FindAllElements())
            {
                if (ctrl.Current.LocalizedControlType != "タブ項目") { continue; }
                tabPageList.Add(new AETabPage(ctrl));
            }
            return tabPageList;
        }

        protected int GetSelectedIndex()
        {
            for (int idx = 0; idx < TabPages.Count; idx++)
            {
                if (TabPages[idx].IsFocus) { return idx; }
            }
            return -1;
        }
    }
}
