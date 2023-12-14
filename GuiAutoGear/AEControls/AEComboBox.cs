using System.Collections.Generic;
using System.Windows.Automation;

namespace GuiAutoGear.AEControls
{
    public class AEComboBox : AEControlBase
    {
#if TBD
        public List<AEListItem> Items { get => GetItems(); }

        public int SelectedIndex { get => mElement.GetListSelectedIndex(); }
#endif
        public string Text
        {
            get { return ValuePattern.Current.Value; }
            set { ValuePattern.SetValue(value); }
        }

#if TBD
        public AEListItem SelectedItem
        {
            get
            {
                var idx = SelectedIndex;
                if (idx == -1) { return null; }
                return Items[idx];
            }
        }

        public string SelectedText
        {
            get
            {
                var item = SelectedItem;
                if (item == null) { return string.Empty; }
                return item.Text;
            }
        }
#endif

        public AEComboBox(AutomationElement automationElement)
            : base(automationElement)
        {
        }

        public AEComboBox(AutomationElement rootElement, string automationId)
            : base(rootElement, automationId)
        {
        }

#if TBD
        protected List<AEListItem> GetItems()
        {
            ExpandCollapsePattern.Expand();
            var aeElements = mElement.FindAllElements(true);
            var itemList = new List<AEListItem>();
            for (int idx = 0; idx < aeElements.Count; idx++)
            {
                itemList.Add(new AEListItem(aeElements[idx], idx));
            }
            return itemList;
        }
#endif
    }
}
