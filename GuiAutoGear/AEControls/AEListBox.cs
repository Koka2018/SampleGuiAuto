﻿using System;
using System.Collections.Generic;
using System.Windows.Automation;

namespace GuiAutoGear.AEControls
{
    public class AEListBox : AEControlBase
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
                if(idx == -1) { return null; }
                return Items[idx];
            }
        }

        public string SelectedText 
        {
            get 
            {
                var item = SelectedItem;
                if(item == null){ return string.Empty; }
                return item.Text;
            }
        }

        public AEListBox(AutomationElement automationElement)
            : base(automationElement)
        {
        }

        public AEListBox(AutomationElement rootElement, string automationId)
            : base(rootElement, automationId)
        {
        }

        public AEListBox(AEControlBase rootCtrl, string automationId)
            : base(rootCtrl, automationId)
        {
        }

        protected List<AEListItem> GetItems()
        {
            var aeElements = mElement.GetListItems();
            var itemList = new List<AEListItem>();
            for(int idx = 0; idx < aeElements.Count; idx++)
            {
                itemList.Add(new AEListItem(aeElements[idx], idx));
            }
            return itemList;
        }
    }
}
