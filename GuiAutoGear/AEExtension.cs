using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;

namespace GuiAutoGear
{
    public static class AEExtension
    {
        public static AutomationElement FindElement(
            this AutomationElement rootElement,
            string automationId,
            bool withAllChildren = false)
        {
            var condition = new PropertyCondition(AutomationElement.AutomationIdProperty, automationId);
            var scope = withAllChildren
                ? TreeScope.Descendants | TreeScope.Subtree
                : TreeScope.Descendants;
            return rootElement.FindFirst(scope, condition);
        }

        public static void ShowInfo(
            this AutomationElement rootElement,
            bool withAllChildren = false)
        {
            foreach (AutomationElement aeChild in FindAllElements(rootElement, withAllChildren))
            {
                Console.WriteLine(aeChild.Current.AutomationId);
            }
        }

        public static AutomationElementCollection FindAllElements(
            this AutomationElement rootElement,
            bool withAllChildren = false)
        {
            var condition = new PropertyCondition(AutomationElement.FrameworkIdProperty, "WinForm");
            var scope = withAllChildren
                ? TreeScope.Descendants | TreeScope.Children
                : TreeScope.Descendants;
            return rootElement.FindAll(scope, condition);
        }

        public static AutomationElement FindElementsByName(
            this AutomationElement rootElement,
            string name,
            bool withAllChilderm = false)
        {
            var condition = new PropertyCondition(AutomationElement.NameProperty, name);
            var scope = withAllChilderm
                ? TreeScope.Descendants | TreeScope.Children
                : TreeScope.Descendants;

            return rootElement.FindFirst(scope, condition);
        }

        public static ValuePattern GetValuePattern(this AutomationElement element)
        {
            return (ValuePattern)element.GetCurrentPattern(ValuePattern.Pattern);
        }

        public static InvokePattern GetInvokePattern(this AutomationElement element)
        {
            return (InvokePattern)element.GetCurrentPattern(InvokePattern.Pattern);
        }

        public static ExpandCollapsePattern GetExpandCollapsePattern(this AutomationElement element)
        {
            return (ExpandCollapsePattern)element.GetCurrentPattern(ExpandCollapsePattern.Pattern);
        }

        public static TogglePattern GetTogglePattern(this AutomationElement element)
        {
            return (TogglePattern)element.GetCurrentPattern(TogglePattern.Pattern);
        }

        public static SelectionItemPattern GetSelectionItemPattern(this AutomationElement element)
        {
            return (SelectionItemPattern)element.GetCurrentPattern(SelectionItemPattern.Pattern);
        }

        public static AutomationElementCollection GetListItems(this AutomationElement element)
        {
            var condition = new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.ListItem);
            return element.FindAll(TreeScope.Children, condition);
        }

        public static AutomationElementCollection GetComboItems(this AutomationElement element)
        {
            var condition = new PropertyCondition(AutomationElement.ControlTypeProperty, ControlType.ListItem);
            return element.FindAll(TreeScope.Subtree, condition);
        }

        public static int GetListSelectedIndex(this AutomationElement element)
        {
            var listItems = element.GetListItems();
            for (int idx = 0; idx < listItems.Count; idx++)
            {
                AutomationElement item = listItems[idx];
                if (item.GetSelectionItemPattern().Current.IsSelected)
                {
                    return idx;
                }
            }
            return -1;
        }
    }
}
