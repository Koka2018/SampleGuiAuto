using System.Collections.Generic;
using System.Windows.Automation;

namespace GuiAutoGear.AEControls
{
    public class AEComboBox : AEControlBase
    {
        public List<AEListItem> Items { get => GetItems(); }

        public int SelectedIndex
        {
            get => mElement.GetListSelectedIndex();
            set { Items[value].Focus(); }
        }
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

        public AEComboBox(AEControlBase rootCtrl, string automationId)
            : base(rootCtrl, automationId)
        {
        }

        protected List<AEListItem> GetItems()
        {
#if TBD
            ExpandCollapsePattern.Expand();
            var aeElements = mElement.FindAllElements(true);
            var itemList = new List<AEListItem>();
            for (int idx = 0; idx < aeElements.Count; idx++)
            {
                itemList.Add(new AEListItem(aeElements[idx], idx));
            }
#else
            var aeElements = mElement.GetComboItems();
            var itemList = new List<AEListItem>();
            for (int idx = 0; idx < aeElements.Count; idx++)
            {
                itemList.Add(new AEListItem(aeElements[idx], idx));
            }
#endif
            return itemList;
        }

#if TBD
        // UIApp画面のcomboBoxを取得
            AutomationElement　elementComboBox = this.GetFromControl("comboBox");
            // comboBoxからアイテムリストを取得
            AutomationElementCollection collection = elementComboBox.FindAll(TreeScope.Subtree,
		new PropertyCondition(AutomationElement.ControlTypeProperty.ControlType.ListItem));
#endif
    }
}
