using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP.DragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is TextBox)
                DoDragDrop(((TextBox)sender).Text, DragDropEffects.All);
            else if (sender is ListBox)
                DoDragDrop(((ListBox)sender).SelectedItem, DragDropEffects.All);
                
        }


        private void tBox_DragDrop(object sender, DragEventArgs e)
        {
            if(sender is TextBox)
                ((TextBox) sender).Text = e.Data.GetData(DataFormats.Text).ToString();
            else if(sender is ListBox)
                ((ListBox)sender).Items.Add(e.Data.GetData(DataFormats.Text).ToString());

        }

        private void tBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void tBox_DragLeave(object sender, EventArgs e)
        {/*
            if (sender is TextBox)
                ((TextBox)sender).Clear();
            else if (sender is ListBox)             
                ((ListBox)sender).Items.Remove(((ListBox)sender).SelectedItem);*/
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            ListViewItem lv = new ListViewItem();
            lv.Text = e.Data.GetData(DataFormats.Text).ToString();
            lv.SubItems.Add("Baldo");
            listView1.Items.Add(lv);
        }

        private void listView2_DragDrop(object sender, DragEventArgs e)
        {
            ListView.SelectedListViewItemCollection cosas =(ListView.SelectedListViewItemCollection) e.Data.GetData(typeof(ListView.SelectedListViewItemCollection));
            foreach (ListViewItem item in cosas)
            {
                listView2.Items.Add((ListViewItem)item.Clone());
            }
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(((ListView)sender).SelectedItems, DragDropEffects.All);
        }
    }
}
