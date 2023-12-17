using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Automation;

namespace GuiAutoGear.AEControls
{
    public class AECheckedListBox : AEControlBase
    {
        public List<AEListItem> Items { get => GetItems(); }

        public int SelectedIndex
        {
            get => mElement.GetListSelectedIndex();
            set { Items[value].Focus(); }
        }

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

        public AECheckedListBox(AutomationElement automationElement)
            : base(automationElement)
        {
        }

        public AECheckedListBox(AutomationElement rootElement, string automationId)
            : base(rootElement, automationId)
        {
        }

        public AECheckedListBox(AEControlBase rootCtrl, string automationId)
            : base(rootCtrl, automationId)
        {
        }

        public void Check(int idx, bool isCheck)
        {
            if (IsChecked(idx) == isCheck) { return; }
            var checks = GetChecks();
            var checkElement = new AECheckBox(checks[idx + 1].Element);
            //checkElement.Checked = isCheck;
            //Items[idx].Element.GetTogglePattern().Toggle();
            checkElement.Checked = isCheck;
        }

        public bool IsChecked(int idx)
        {
            var state = Items[idx].Element.GetTogglePattern().Current.ToggleState;
            return state == ToggleState.On;
        }

        protected List<AEListItem> GetItems()
        {
            var aeElements = mElement.GetListItems();
            var itemList = new List<AEListItem>();
            for (int idx = 0; idx < aeElements.Count; idx++)
            {
                itemList.Add(new AEListItem(aeElements[idx], idx));
            }
            return itemList;
        }

        protected List<AECheckBox> GetChecks()
        {
            var aeListItems = mElement.FindAll(TreeScope.Children, Condition.TrueCondition);
            var checkList = new List<AECheckBox>();
            for (int idx = 0; idx < aeListItems.Count; idx++)
            {
                var condition = new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.CheckBox);
                var checkBox = aeListItems[idx].FindFirst(TreeScope.Children, condition);

                checkList.Add(new AECheckBox(checkBox));
            }
            return checkList;
        }
    }
}
