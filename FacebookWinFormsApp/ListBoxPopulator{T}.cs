using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class ListBoxPopulator<T>
{
    private readonly IEnumerable<T> m_Items;
    private readonly ListBox m_ListBox;

    public ListBoxPopulator(IEnumerable<T> items, ListBox listBox)
    {
        m_Items = items;
        m_ListBox = listBox;
    }

    public void FetchAndPopulateData(IEnumerable<T> items, ListBox listBox)
    {
        try
        {
            m_ListBox.Invoke(new Action(() => m_ListBox.DisplayMember = "Name"));
            m_ListBox.Invoke(new Action(() => m_ListBox.BeginUpdate()));
            m_ListBox.Invoke(new Action(() => m_ListBox.Items.Clear()));
            
            foreach (T item in m_Items)
                {
                    if (item != null)
                    {
                        m_ListBox.Invoke(new Action(() => m_ListBox.Items.Add(item)));
                    }
                }

                m_ListBox.Invoke(new Action(() => m_ListBox.EndUpdate()));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
