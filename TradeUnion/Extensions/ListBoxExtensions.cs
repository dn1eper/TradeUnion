using System;
using System.Windows.Forms;

namespace TradeUnion.Extensions
{
    static class ListBoxExtensions
    {
        public static void DeleteItems(this ListBox listBox, params int[] indices)
        {
            for (int i = indices.Length - 1; i >= 0; i--)
            {
                listBox.Items.RemoveAt(indices[i]);
            }
        }

        public static void DeleteSelectedItems(this ListBox listBox)
        {
            int[] indices = new int[listBox.SelectedIndices.Count];
            listBox.SelectedIndices.CopyTo(indices, 0);
            listBox.DeleteItems(indices);
        }

        public static void UpdateItem(this ListBox listBox, int index)
        {
            object item = listBox.Items[index];
            listBox.Items.RemoveAt(index);
            listBox.Items.Insert(index, item);
        }

        public static void UpdateSelectedItem(this ListBox listBox)
        {
            listBox.UpdateItem(listBox.SelectedIndex);
        }
    }
}
