using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace ErrObserver.ComboBoxMethods
{
    class ListBoxes
    {
        static public bool isEmpty(ListBox lb)
        {
            var count = lb.Items.Count;
            return count > 0 ? true : false;
        }

        static public bool isDuplicate(ListBox lb, ref string newItem)
        {
            foreach(var item in lb.Items)
            {
                if (item == newItem)
                    return true;
            }    
            return false;
        }

        static public void deleteSpecificItem(ListBox lb)
        {
            int selectedItem = lb.SelectedIndex;
            if (selectedItem != -1)
                lb.Items.RemoveAt(selectedItem);
            else
                MessageBox.Show("Brak zaznaczonego elementu", "INFORMACJA", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
